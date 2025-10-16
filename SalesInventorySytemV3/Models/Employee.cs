using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesInventorySytemV3.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public Role Role { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}