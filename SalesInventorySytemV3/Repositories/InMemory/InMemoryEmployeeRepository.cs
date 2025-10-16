using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesInventorySytemV3.Models;
using SalesInventorySytemV3.Repositories.Interfaces;


namespace SalesInventorySytemV3.Repositories.InMemory
{
    public class InMemoryEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public InMemoryEmployeeRepository()
        {
            _employees.Add(new Employee
            {
                Id = 1,
                Username = "admin",
                Password = "admin123",
                FullName = "System Administrator",
                Role = Role.Administrator,
                Status = "active",
                CreatedDate = DateTime.UtcNow
            });

            _employees.Add(new Employee
            {
                Id = 2,
                Username = "cashier",
                Password = "cashier123",
                FullName = "Store Cashier",
                Role = Role.Cashier,
                Status = "active",
                CreatedDate = DateTime.UtcNow
            });
        }

        public IEnumerable<Employee> GetAll() => _employees.ToList();

        public Employee GetByUsername(string username) =>
            _employees.FirstOrDefault(x =>
                x.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

        public Employee GetById(int id) =>
            _employees.FirstOrDefault(x => x.Id == id);

        public void Add(Employee employee) =>
            _employees.Add(employee);

        public int NextId() =>
            _employees.Count == 0 ? 1 : _employees.Max(x => x.Id) + 1;
    }
}