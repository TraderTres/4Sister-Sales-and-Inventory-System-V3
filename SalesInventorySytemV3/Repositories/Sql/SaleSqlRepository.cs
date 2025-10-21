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
            string saleQuery = "SELECT * FROM Sales ORDER BY CreatedDate DESC"; // ✅ use CreatedDate

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
                            // ✅ SAFE READ
                            CreatedDate = reader.IsDBNull(reader.GetOrdinal("CreatedDate"))
                                ? DateTime.Now
                                : reader.GetDateTime(reader.GetOrdinal("CreatedDate")),
                            Total = reader.GetDecimal(reader.GetOrdinal("Total")),
                            PaymentMethod = reader.GetString(reader.GetOrdinal("PaymentMethod")),
                            Reference = reader.IsDBNull(reader.GetOrdinal("Reference"))
                                ? ""
                                : reader.GetString(reader.GetOrdinal("Reference")),
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
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        if (sale.CreatedDate == default) // ✅ safeguard
                            sale.CreatedDate = DateTime.Now;

                        string saleQuery = @"
                            INSERT INTO Sales (CreatedDate, Total, PaymentMethod, Reference)
                            VALUES (@CreatedDate, @Total, @PaymentMethod, @Reference);
                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                        using (var saleCmd = new SqlCommand(saleQuery, conn, transaction))
                        {
                            saleCmd.Parameters.AddWithValue("@CreatedDate", sale.CreatedDate);
                            saleCmd.Parameters.AddWithValue("@Total", sale.Total);
                            saleCmd.Parameters.AddWithValue("@PaymentMethod", sale.PaymentMethod);
                            saleCmd.Parameters.AddWithValue("@Reference", sale.Reference ?? (object)DBNull.Value);

                            sale.Id = (int)saleCmd.ExecuteScalar();
                        }

                        foreach (var item in sale.Items)
                        {
                            string itemQuery = @"
                                INSERT INTO SaleItems (SaleId, ProductId, Name, Quantity, Price)
                                VALUES (@SaleId, @ProductId, @Name, @Quantity, @Price);";

                            using (var itemCmd = new SqlCommand(itemQuery, conn, transaction))
                            {
                                itemCmd.Parameters.AddWithValue("@SaleId", sale.Id);
                                itemCmd.Parameters.AddWithValue("@ProductId", item.ProductId);
                                itemCmd.Parameters.AddWithValue("@Name", item.Name);
                                itemCmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                                itemCmd.Parameters.AddWithValue("@Price", item.Price);
                                itemCmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
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
                var result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    nextId = Convert.ToInt32(result);
            }

            return nextId;
        }
    }
}