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
    public class EmployeeSqlRepository : IEmployeeRepository
    {
        private readonly string _connectionString;

        public EmployeeSqlRepository()
        {
            var settings = ConfigurationManager.ConnectionStrings["MyDb"];
            if (settings == null || string.IsNullOrWhiteSpace(settings.ConnectionString))
                throw new Exception("Connection string 'MyDb' not found in App.config!");

            _connectionString = settings.ConnectionString;
        }

        public IEnumerable<Employee> GetAll()
        {
            var employees = new List<Employee>();
            string query = "SELECT * FROM Employees";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(new Employee
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Username = reader.GetString(reader.GetOrdinal("Username")),
                            Password = reader.GetString(reader.GetOrdinal("Password")),
                            FullName = reader.GetString(reader.GetOrdinal("FullName")),
                            Role = (Role)reader.GetInt32(reader.GetOrdinal("Role")),
                            Status = reader.GetString(reader.GetOrdinal("Status")),
                            CreatedDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"))
                        });
                    }
                }
            }
            return employees;
        }

        public Employee GetByUsername(string username)
        {
            Employee emp = null;
            string query = "SELECT * FROM Employees WHERE Username = @Username";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        emp = new Employee
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Username = reader.GetString(reader.GetOrdinal("Username")),
                            Password = reader.GetString(reader.GetOrdinal("Password")),
                            FullName = reader.GetString(reader.GetOrdinal("FullName")),
                            Role = (Role)reader.GetInt32(reader.GetOrdinal("Role")),
                            Status = reader.GetString(reader.GetOrdinal("Status")),
                            CreatedDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"))
                        };
                    }
                }
            }
            return emp;
        }

        public Employee GetById(int id)
        {
            Employee employee = null;
            string query = "SELECT * FROM Employees WHERE Id = @Id";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        employee = new Employee
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Username = reader.GetString(reader.GetOrdinal("Username")),
                            Password = reader.GetString(reader.GetOrdinal("Password")),
                            FullName = reader.GetString(reader.GetOrdinal("FullName")),
                            Role = (Role)reader.GetInt32(reader.GetOrdinal("Role")),
                            Status = reader.GetString(reader.GetOrdinal("Status")),
                            CreatedDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"))
                        };
                    }
                }
            }
            return employee;
        }

        public void Add(Employee employee)
        {
            string query = @"
                INSERT INTO Employees (Username, Password, FullName, Role, Status, CreatedDate)
                VALUES (@Username, @Password, @FullName, @Role, @Status, @CreatedDate);
                SELECT CAST(SCOPE_IDENTITY() AS INT);
            ";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Username", employee.Username);
                cmd.Parameters.AddWithValue("@Password", employee.Password);
                cmd.Parameters.AddWithValue("@FullName", employee.FullName);
                cmd.Parameters.AddWithValue("@Role", (int)employee.Role);
                cmd.Parameters.AddWithValue("@Status", employee.Status);
                cmd.Parameters.AddWithValue("@CreatedDate", employee.CreatedDate);

                conn.Open();
                int newId = (int)cmd.ExecuteScalar();
                employee.Id = newId;
            }
        }

        public int NextId()
        {
            int nextId = 1;
            string query = "SELECT ISNULL(MAX(Id), 0) + 1 FROM Employees";

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
