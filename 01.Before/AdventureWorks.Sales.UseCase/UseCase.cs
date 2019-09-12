using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace AdventureWorks.Sales.UseCase
{
    public class UseCase : IUseCase
    {
        private readonly IRepository _repository;

        private readonly string _connectionString;

        public UseCase(IRepository repository, string connectionString)
        {
            _repository = repository;
            _connectionString = connectionString;
        }

        public IEnumerable<ProductSales> GerProductSales()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // 注文明細を全て取得し、プロダクトIDでグルーピングし、プロダクトID別の総売上を集計する
                var salesByProductId =
                    _repository.GetSalesOrderDetail(connection)
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
                    _repository.GetProducts(connection)
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
                        .OrderByDescending(productSales => productSales.Sales);
            }
        }
    }
}
