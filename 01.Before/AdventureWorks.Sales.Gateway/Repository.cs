using System.Collections.Generic;
using System.Data;
using System.Linq;
using AdventureWorks.Sales.Entities;
using Dapper.FastCrud;

namespace AdventureWorks.Sales.Gateways
{
    public class Repository : IRepository
    {
        public IEnumerable<ProductSales> GetProductSales(IDbConnection connection)
        {
            // 注文明細を全て取得し、プロダクトIDでグルーピングし、プロダクトID別の総売上を集計する
            var salesByProductId =
                connection.Find<SalesOrderDetail>()
                    .GroupBy(salesOrderDetail => salesOrderDetail.ProductID)
                    .Select(x =>
                        new
                        {
                            ProductID = x.Key,
                            TotalAmount = x.Sum(salesOrderDetail => salesOrderDetail.LineTotal)
                        });
            // 全てのプロダクトを取得し、先に集計したプロダクトID別の総売上とJoinする。
            // その上で、プロダクト名別 総売上リストを作成し、売上額の多い順にソートする。
            return
                connection.Find<Product>()
                    .Join(
                        salesByProductId,
                        p => p.ProductID,
                        s => s.ProductID,
                        (p, s) =>
                            new ProductSales
                            {
                                Name = p.Name,
                                Sales = s.TotalAmount
                            })
                    .OrderByDescending(x => x.Sales);
        }
    }
}