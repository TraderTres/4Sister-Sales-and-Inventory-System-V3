using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesInventorySytemV3.Models;
using SalesInventorySytemV3.Repositories.Interfaces;

namespace SalesInventorySytemV3.Repositories.InMemory
{
    public class InMemoryProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new List<Product>();

        public InMemoryProductRepository()
        {
        }

        public IEnumerable<Product> GetAll() => _products.ToList();

        public Product GetById(int id) =>
            _products.FirstOrDefault(x => x.Id == id);

        public Product GetByName(string name) =>
            _products.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        public void Add(Product product) =>
            _products.Add(product);

        public void Update(Product product)
        {
            var index = _products.FindIndex(x => x.Id == product.Id);
            if (index >= 0)
                _products[index] = product;
        }

        public int NextId() =>
            _products.Count == 0 ? 1 : _products.Max(x => x.Id) + 1;
    }
}