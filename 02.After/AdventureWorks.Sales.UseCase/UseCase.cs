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

                return _repository.GetProductSales(connection).ToList();
            }
        }
    }
}
