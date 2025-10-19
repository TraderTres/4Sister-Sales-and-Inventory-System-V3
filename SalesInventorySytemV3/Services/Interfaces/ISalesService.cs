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
        void CreateSale(Sale sale);
        IEnumerable<Sale> GetAll();
        int NextId();
        List<Sale> GetSalesForDate(DateTime date);
    }
}
