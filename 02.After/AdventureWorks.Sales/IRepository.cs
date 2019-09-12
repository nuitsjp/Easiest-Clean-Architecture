using System.Collections.Generic;
using System.Data;

namespace AdventureWorks.Sales.Entity
{
    public interface IRepository
    {
        IEnumerable<ProductSales> GetProductSales(IDbConnection connection);
    }
}