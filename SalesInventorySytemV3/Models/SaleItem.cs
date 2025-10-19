using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesInventorySytemV3.Models
{
    public class SaleItem
    {
        public int Id { get; set; } 
        public int SaleId { get; set; } 
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}