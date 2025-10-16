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
    public class AuthService : IAuthService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public AuthService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee ValidateLogin(string username, string password)
        {
            var emp = _employeeRepository.GetByUsername(username);

            if (emp != null &&
                emp.Password == password &&
                emp.Status == "active")
            {
                return emp;
            }

            return null;
        }
    }
}