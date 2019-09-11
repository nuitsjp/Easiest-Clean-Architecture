using System.Collections.Generic;
using System.Data;

namespace AdventureWorks.Sales
{
    public interface IRepository
    {
        IEnumerable<ProductSales> GetProductSales(IDbConnection connection);
    }
}