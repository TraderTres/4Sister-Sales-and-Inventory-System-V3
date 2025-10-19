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
    public class SalesService : ISalesService
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IProductRepository _productRepository;

        public SalesService(ISaleRepository saleRepository, IProductRepository productRepository)
        {
            _saleRepository = saleRepository;
            _productRepository = productRepository;
        }

        public void CreateSale(Sale sale)
        {
            if (sale == null || sale.Items.Count == 0)
                throw new InvalidOperationException("Sale is empty.");

            foreach (var item in sale.Items)
            {
                var product = _productRepository.GetById(item.ProductId);

                if (product == null)
                    throw new InvalidOperationException("Product not found.");

                if (product.Stock < item.Quantity)
                    throw new InvalidOperationException($"Not enough stock for {product.Name}.");

                product.Stock -= item.Quantity;
                _productRepository.Update(product);
            }

            sale.Id = _saleRepository.NextId();
            sale.Date = DateTime.Now;

            _saleRepository.Add(sale);
        }

        public IEnumerable<Sale> GetAll() =>
            _saleRepository.GetAll();

        public int NextId() =>
            _saleRepository.NextId();
    
    private List<Sale> _sales = new List<Sale>();

        public List<Sale> GetSalesForDate(DateTime date)
        {
            return _sales.Where(s => s.Date.Date == date.Date).ToList();
        }
    }
}