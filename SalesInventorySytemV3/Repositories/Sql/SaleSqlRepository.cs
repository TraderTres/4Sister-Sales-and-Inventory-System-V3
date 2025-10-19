using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using SalesInventorySytemV3.Models;
using SalesInventorySytemV3.Repositories.Interfaces;

namespace SalesInventorySytemV3.Repositories.Sql
{
    public class SaleSqlRepository : ISaleRepository
    {
        private readonly string _connectionString;

        public SaleSqlRepository()
        {
            var settings = ConfigurationManager.ConnectionStrings["MyDb"];
            if (settings == null || string.IsNullOrWhiteSpace(settings.ConnectionString))
                throw new Exception("Connection string 'MyDb' not found in App.config!");

            _connectionString = settings.ConnectionString;
        }

        public IEnumerable<Sale> GetAll()
        {
            var sales = new List<Sale>();
            string saleQuery = "SELECT * FROM Sales ORDER BY Date DESC";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(saleQuery, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sales.Add(new Sale
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                            Total = reader.GetDecimal(reader.GetOrdinal("Total")),
                            PaymentMethod = reader.GetString(reader.GetOrdinal("PaymentMethod")),
                            Reference = reader.GetString(reader.GetOrdinal("Reference")),
                            Items = new List<SaleItem>()
                        });
                    }
                }

                if (sales.Count == 0)
                    return sales;

                var saleIds = string.Join(",", sales.ConvertAll(s => s.Id));
                string itemsQuery = $"SELECT * FROM SaleItems WHERE SaleId IN ({saleIds})";

                using (var itemCmd = new SqlCommand(itemsQuery, conn))
                using (var reader = itemCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new SaleItem
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            SaleId = reader.GetInt32(reader.GetOrdinal("SaleId")),
                            ProductId = reader.GetInt32(reader.GetOrdinal("ProductId")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                            Price = reader.GetDecimal(reader.GetOrdinal("Price"))
                        };

                        var sale = sales.Find(s => s.Id == item.SaleId);
                        sale?.Items.Add(item);
                    }
                }
            }
            return sales;
        }

        public void Add(Sale sale)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        string insertSaleQuery = @"
                            INSERT INTO Sales (Date, Total, PaymentMethod, Reference)
                            VALUES (@Date, @Total, @PaymentMethod, @Reference);
                            SELECT CAST(SCOPE_IDENTITY() AS INT);
                        ";

                        int saleId;
                        using (var cmd = new SqlCommand(insertSaleQuery, conn, tran))
                        {
                            cmd.Parameters.AddWithValue("@Date", sale.Date);
                            cmd.Parameters.AddWithValue("@Total", sale.Total);
                            cmd.Parameters.AddWithValue("@PaymentMethod", sale.PaymentMethod);
                            cmd.Parameters.AddWithValue("@Reference", sale.Reference);

                            saleId = (int)cmd.ExecuteScalar();
                        }

                        string insertItemQuery = @"
                            INSERT INTO SaleItems (SaleId, ProductId, Name, Quantity, Price)
                            VALUES (@SaleId, @ProductId, @Name, @Quantity, @Price);
                            SELECT CAST(SCOPE_IDENTITY() AS INT);
                        ";

                        foreach (var item in sale.Items)
                        {
                            using (var cmd = new SqlCommand(insertItemQuery, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@SaleId", saleId);
                                cmd.Parameters.AddWithValue("@ProductId", item.ProductId);
                                cmd.Parameters.AddWithValue("@Name", item.Name);
                                cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                                cmd.Parameters.AddWithValue("@Price", item.Price);

                                int newItemId = (int)cmd.ExecuteScalar();
                                item.Id = newItemId;
                                item.SaleId = saleId;
                            }
                        }

                        sale.Id = saleId;
                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        public int NextId()
        {
            int nextId = 1;
            string query = "SELECT ISNULL(MAX(Id), 0) + 1 FROM Sales";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    nextId = Convert.ToInt32(result);
            }
            return nextId;
        }
    }
}