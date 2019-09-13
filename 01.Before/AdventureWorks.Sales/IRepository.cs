using System.Collections.Generic;
using System.Data;

namespace AdventureWorks.Sales.Entities
{
    public interface IRepository
    {
        IEnumerable<ProductSales> GetProductSales(IDbConnection connection);
    }
}