﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesInventorySytemV3.Models;

namespace SalesInventorySytemV3.Services.Interfaces
{
    public interface ISalesService
    {
        IEnumerable<Sale> GetAll();
        void Add(Sale sale);         
        int NextId();
        List<Sale> GetSalesForDate(DateTime date);
<<<<<<< HEAD
=======
        IEnumerable<Sale> GetSalesBetween(DateTime startDate, DateTime endDate);
        IEnumerable<(DateTime Date, decimal Total)> GetSalesSummaryByDate(DateTime startDate, DateTime endDate);
        IEnumerable<(int ProductId, string ProductName, decimal TotalSold)> GetTopProducts(DateTime startDate, DateTime endDate, int topN = 10);

>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
    }
}
