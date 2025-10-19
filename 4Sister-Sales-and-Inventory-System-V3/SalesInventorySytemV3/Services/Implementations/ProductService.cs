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
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAllActive() =>
            _productRepository.GetAll().Where(p => p.Active);

        public Product GetById(int id) =>
            _productRepository.GetById(id);

        public Product GetByName(string name) =>
            _productRepository.GetByName(name);

        public void AddProduct(Product product) =>
            _productRepository.Add(product);

        public void UpdateProduct(Product product) =>
            _productRepository.Update(product);

        public int NextId() =>
            _productRepository.NextId();
    }
}