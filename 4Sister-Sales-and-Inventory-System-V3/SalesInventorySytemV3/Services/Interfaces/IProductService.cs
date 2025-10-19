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
        IEnumerable<Product> GetAllActive();
        Product GetById(int id);
        Product GetByName(string name);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        int NextId();
    }
}