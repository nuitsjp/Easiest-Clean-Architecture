using System;
using System.Collections.Generic;
using System.Data;
using Dapper.FastCrud;

namespace AdventureWorks.Sales
{
    public class Repository : IRepository
    {
        public IEnumerable<Product> GetProducts(IDbConnection connection)
        {
            return connection.Find<Product>();
        }

        public IEnumerable<SalesOrderDetail> GetSalesOrderDetail(IDbConnection connection)
        {
            return connection.Find<SalesOrderDetail>();
        }
    }
}