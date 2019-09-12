using System.Collections.Generic;
using System.Data;
using AdventureWorks.Sales.Domain;

namespace AdventureWorks.Sales.Entity
{
    public interface IRepository
    {
        IEnumerable<Product> GetProducts(IDbConnection connection);
        IEnumerable<SalesOrderDetail> GetSalesOrderDetail(IDbConnection connection);
    }
}