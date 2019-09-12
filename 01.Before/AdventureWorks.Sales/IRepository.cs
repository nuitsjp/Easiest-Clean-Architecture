using System.Collections.Generic;
using System.Data;

namespace AdventureWorks.Sales
{
    public interface IRepository
    {
        IEnumerable<Product> GetProducts(IDbConnection connection);
        IEnumerable<SalesOrderDetail> GetSalesOrderDetail(IDbConnection connection);
    }
}