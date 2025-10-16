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
            _products.Add(new Product
            {
                Id = 1,
                Name = "Coca Cola 1.5L",
                Category = "Beverages",
                Brand = "Coca Cola",
                Price = 65.00m,
                Stock = 24,
                Unit = "pcs",
                Expiry = new DateTime(2024, 12, 31),
                Active = true
            });

            _products.Add(new Product
            {
                Id = 2,
                Name = "Lucky Me Pancit Canton",
                Category = "Instant Noodles",
                Brand = "Lucky Me",
                Price = 15.50m,
                Stock = 5,
                Unit = "pcs",
                Expiry = new DateTime(2024, 10, 15),
                Active = true
            });

            _products.Add(new Product
            {
                Id = 3,
                Name = "Tide Powder 1kg",
                Category = "Detergent",
                Brand = "Tide",
                Price = 185.00m,
                Stock = 0,
                Unit = "pcs",
                Expiry = null,
                Active = true
            });
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