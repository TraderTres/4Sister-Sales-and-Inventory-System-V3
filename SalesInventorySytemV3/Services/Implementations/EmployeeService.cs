using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesInventorySytemV3.Models;
using SalesInventorySytemV3.Repositories.Interfaces;
using SalesInventorySytemV3.Services.Interfaces;

namespace SalesInventorySytemV3.Services.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetAll() => _employeeRepository.GetAll();

        public IEnumerable<Employee> GetAllActive()
            => _employeeRepository.GetAll().Where(e => e.Status == "Active");

        public Employee GetByUsername(string username)
            => _employeeRepository.GetByUsername(username);

        public Employee GetById(int id)
            => _employeeRepository.GetById(id);

        public void Add(Employee employee)
            => _employeeRepository.Add(employee);

        public int NextId()
            => _employeeRepository.NextId();
    }
}