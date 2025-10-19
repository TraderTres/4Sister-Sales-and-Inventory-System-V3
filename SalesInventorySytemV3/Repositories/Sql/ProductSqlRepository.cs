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
    public class ProductSqlRepository : IProductRepository
    {
        private readonly string _connectionString;

        public ProductSqlRepository()
        {
            var settings = ConfigurationManager.ConnectionStrings["MyDb"];
            if (settings == null || string.IsNullOrWhiteSpace(settings.ConnectionString))
                throw new Exception("Connection string 'MyDb' not found in App.config!");

            _connectionString = settings.ConnectionString;
        }

        public IEnumerable<Product> GetAll()
        {
            var products = new List<Product>();
            string query = "SELECT * FROM Products";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            Category = reader.GetString(reader.GetOrdinal("Category")),
                            Brand = reader.GetString(reader.GetOrdinal("Brand")),
                            Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                            Stock = reader.GetInt32(reader.GetOrdinal("Stock")),
                            Unit = reader.GetString(reader.GetOrdinal("Unit")),
                            Expiry = reader.IsDBNull(reader.GetOrdinal("Expiry"))
                                ? (DateTime?)null
                                : reader.GetDateTime(reader.GetOrdinal("Expiry")),
                            Active = reader.GetBoolean(reader.GetOrdinal("Active"))
                        });
                    }
                }
            }
            return products;
        }

        public Product GetById(int id)
        {
            Product product = null;
            string query = "SELECT * FROM Products WHERE Id = @Id";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        product = new Product
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            Category = reader.GetString(reader.GetOrdinal("Category")),
                            Brand = reader.GetString(reader.GetOrdinal("Brand")),
                            Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                            Stock = reader.GetInt32(reader.GetOrdinal("Stock")),
                            Unit = reader.GetString(reader.GetOrdinal("Unit")),
                            Expiry = reader.IsDBNull(reader.GetOrdinal("Expiry"))
                                ? (DateTime?)null
                                : reader.GetDateTime(reader.GetOrdinal("Expiry")),
                            Active = reader.GetBoolean(reader.GetOrdinal("Active"))
                        };
                    }
                }
            }
            return product;
        }

        public Product GetByName(string name)
        {
            Product product = null;
            string query = "SELECT * FROM Products WHERE Name = @Name";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", name);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        product = new Product
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            Category = reader.GetString(reader.GetOrdinal("Category")),
                            Brand = reader.GetString(reader.GetOrdinal("Brand")),
                            Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                            Stock = reader.GetInt32(reader.GetOrdinal("Stock")),
                            Unit = reader.GetString(reader.GetOrdinal("Unit")),
                            Expiry = reader.IsDBNull(reader.GetOrdinal("Expiry"))
                                ? (DateTime?)null
                                : reader.GetDateTime(reader.GetOrdinal("Expiry")),
                            Active = reader.GetBoolean(reader.GetOrdinal("Active"))
                        };
                    }
                }
            }
            return product;
        }

        public void Add(Product product)
        {
            string query = @"
                INSERT INTO Products (Name, Category, Brand, Price, Stock, Unit, Expiry, Active)
                VALUES (@Name, @Category, @Brand, @Price, @Stock, @Unit, @Expiry, @Active);
                SELECT CAST(SCOPE_IDENTITY() AS INT);
            ";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Category", product.Category);
                cmd.Parameters.AddWithValue("@Brand", product.Brand);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                cmd.Parameters.AddWithValue("@Unit", product.Unit);

                if (product.Expiry.HasValue)
                    cmd.Parameters.AddWithValue("@Expiry", product.Expiry.Value);
                else
                    cmd.Parameters.AddWithValue("@Expiry", DBNull.Value);

                cmd.Parameters.AddWithValue("@Active", product.Active);

                conn.Open();
                int newId = (int)cmd.ExecuteScalar();
                product.Id = newId;
            }
        }

        public void Update(Product product)
        {
            string query = @"
                UPDATE Products SET
                    Name = @Name,
                    Category = @Category,
                    Brand = @Brand,
                    Price = @Price,
                    Stock = @Stock,
                    Unit = @Unit,
                    Expiry = @Expiry,
                    Active = @Active
                WHERE Id = @Id;
            ";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", product.Id);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Category", product.Category);
                cmd.Parameters.AddWithValue("@Brand", product.Brand);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                cmd.Parameters.AddWithValue("@Unit", product.Unit);

                if (product.Expiry.HasValue)
                    cmd.Parameters.AddWithValue("@Expiry", product.Expiry.Value);
                else
                    cmd.Parameters.AddWithValue("@Expiry", DBNull.Value);

                cmd.Parameters.AddWithValue("@Active", product.Active);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public int NextId()
        {
            int nextId = 1;
            string query = "SELECT ISNULL(MAX(Id), 0) + 1 FROM Products";

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