using System.Collections.Generic;
using System.Data;
using Dapper.FastCrud;

namespace AdventureWorks.Sales.Infrastructure
{
    public class Repository : IRepository
    {
        public IEnumerable<ProductSales> GetProductSales(IDbConnection connection)
        {
            throw new System.NotImplementedException();
        }
    }
}