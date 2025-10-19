using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesInventorySytemV3.Models;

namespace SalesInventorySytemV3.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAllActive();
        Product GetById(int id);
        Product GetByName(string name);
        void Add(Product product);
        void Update(Product product);
        int NextId();                          // ✅ NEW
    }
}