using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesInventorySytemV3.Models;

namespace SalesInventorySytemV3.Repositories.Interfaces
{
    public interface ISaleRepository
    {
        IEnumerable<Sale> GetAll();
        void Add(Sale sale);
        int NextId();
    }
}