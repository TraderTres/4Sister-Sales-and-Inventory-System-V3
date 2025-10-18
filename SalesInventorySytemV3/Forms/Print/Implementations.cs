using System;
using System.Collections.Generic;
using System.Linq;
using SalesInventorySytemV3.Models;
using SalesInventorySytemV3.Services.Interfaces;

namespace SalesInventorySytemV3.Services.Implementations
{
    public class SalesService : ISalesService
    {
        
        private List<Sale> _sales = new List<Sale>();

        public List<Sale> GetSalesForDate(DateTime date)
        {
            return _sales.Where(s => s.Date.Date == date.Date).ToList();
        }
    }
}