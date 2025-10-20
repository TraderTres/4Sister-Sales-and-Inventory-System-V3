using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

        // ✅ Fix 1: Use repository instead of local list
        public List<Sale> GetSalesForDate(DateTime date)
        {
            return _saleRepository
                .GetAll()
                .Where(s => s.CreatedDate.Date == date.Date)
                .ToList();
        }

        // ✅ Fix 2: GetSalesBetween uses repository, not _context
        public IEnumerable<Sale> GetSalesBetween(DateTime startDate, DateTime endDate)
        {
            return _saleRepository
                .GetAll()
                .Where(s => s.CreatedDate.Date >= startDate.Date && s.CreatedDate.Date <= endDate.Date)
                .ToList();
        }
    }
}