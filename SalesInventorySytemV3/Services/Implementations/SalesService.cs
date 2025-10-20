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
        private List<Sale> _sales = new List<Sale>();

        public SalesService(ISaleRepository saleRepository, IProductRepository productRepository)
        {
            _saleRepository = saleRepository;
            _productRepository = productRepository;
        }

        public IEnumerable<Sale> GetAll() => _saleRepository.GetAll();

        public int NextId() => _saleRepository.NextId();

        public void Add(Sale sale)
        {
            foreach (var item in sale.Items)
            {
                var product = _productRepository.GetById(item.ProductId);
                if (product != null)
                {
                    product.Stock -= item.Quantity;
                    _productRepository.Update(product);
                }
            }
            _saleRepository.Add(sale);
        }

        public List<Sale> GetSalesForDate(DateTime date)
        {
            return _sales.Where(s => s.CreatedDate.Date == date.Date).ToList();
        }
    }
}