using System.Collections.Generic;
using System.Data;
using AdventureWorks.Sales.Entity;
using Dapper;

namespace AdventureWorks.Sales.Gateway
{
    public class Repository : IRepository
    {
        public IEnumerable<ProductSales> GetProductSales(IDbConnection connection)
        {
            return connection.Query<ProductSales>(Properties.Resources.GetProductSales);
        }
    }
}