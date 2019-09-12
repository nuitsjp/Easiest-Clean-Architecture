using System.Collections.Generic;
using System.Data;
using Dapper;

namespace AdventureWorks.Sales.Infrastructure
{
    public class Repository : IRepository
    {
        public IEnumerable<ProductSales> GetProductSales(IDbConnection connection)
        {
            return connection.Query<ProductSales>(Properties.Resources.GetProductSales);
        }
    }
}