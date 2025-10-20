using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesInventorySytemV3.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }  
        public decimal Total { get; set; }
        public string PaymentMethod { get; set; }
        public string Reference { get; set; }
        public List<SaleItem> Items { get; set; }

        public Sale()
        {
            CreatedDate = DateTime.Now;  
            Items = new List<SaleItem>();
        }
    }
}