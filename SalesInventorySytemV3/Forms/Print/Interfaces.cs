using System;
using System.Collections.Generic;
using SalesInventorySytemV3.Models;
namespace SalesInventorySytemV3.Services.Interfaces
{
    public interface ISalesService
    {
        // Your existing methods here...

        // Add this new method
        List<Sale> GetSalesForDate(DateTime date);
    }
}