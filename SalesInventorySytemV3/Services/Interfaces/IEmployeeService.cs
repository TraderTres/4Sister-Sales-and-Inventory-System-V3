using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesInventorySytemV3.Models;

namespace SalesInventorySytemV3.Services.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        IEnumerable<Employee> GetAllActive();
        Employee GetByUsername(string username);
        Employee GetById(int id);
        void Add(Employee employee);
        int NextId();
    }
}