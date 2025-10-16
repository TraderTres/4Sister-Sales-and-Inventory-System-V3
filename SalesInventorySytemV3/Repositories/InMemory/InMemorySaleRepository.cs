using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesInventorySytemV3.Models;
using SalesInventorySytemV3.Repositories.Interfaces;

namespace SalesInventorySytemV3.Repositories.InMemory
{
    public class InMemorySaleRepository : ISaleRepository
    {
        private readonly List<Sale> _sales = new List<Sale>();

        public IEnumerable<Sale> GetAll() => _sales.ToList();

        public void Add(Sale sale)
        {
            _sales.Add(sale);
        }

        public int NextId() =>
            _sales.Count == 0 ? 1 : _sales.Max(x => x.Id) + 1;
    }
}