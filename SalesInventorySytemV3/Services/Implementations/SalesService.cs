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
        public IEnumerable<(DateTime Date, decimal Total)> GetSalesSummaryByDate(DateTime startDate, DateTime endDate)
        {
            return _saleRepository.GetAll()
                .Where(s => s.CreatedDate >= startDate && s.CreatedDate <= endDate)
                .SelectMany(s => s.Items.Select(i => new { s.CreatedDate, Total = i.Price * i.Quantity }))
                .GroupBy(x => x.CreatedDate.Date)
                .Select(g => (g.Key, g.Sum(x => x.Total)))
                .OrderBy(x => x.Key)
                .ToList();
        }

        public IEnumerable<(int ProductId, string ProductName, decimal TotalSold)> GetTopProducts(DateTime startDate, DateTime endDate, int topN = 10)
        {
            return _saleRepository.GetAll()
                .Where(s => s.CreatedDate >= startDate && s.CreatedDate <= endDate)
                .SelectMany(s => s.Items)
                .GroupBy(i => new { i.ProductId, i.Name })
                .Select(g => (g.Key.ProductId, g.Key.Name, g.Sum(i => i.Price * i.Quantity)))
                .OrderByDescending(x => x.Item3)
                .Take(topN)
                .ToList();
        }

<<<<<<< HEAD
        public int NextId() =>
            _saleRepository.NextId();
    
    private List<Sale> _sales = new List<Sale>();

        public List<Sale> GetSalesForDate(DateTime date)
        {
            return _sales.Where(s => s.Date.Date == date.Date).ToList();
        }
=======
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
    }
}