using System;
using System.Collections.Generic;
using System.Linq;
using AdventureWorks.Sales.Entity;
using Microsoft.Data.SqlClient;

namespace AdventureWorks.Sales.UseCase
{
    public class UseCase : IUseCase
    {
        private readonly IPresenter _presenter;
        private readonly IRepository _repository;

        private readonly string _connectionString;

        public UseCase(IPresenter presenter, IRepository repository, string connectionString)
        {
            _presenter = presenter;
            _repository = repository;
            _connectionString = connectionString;
        }

        public void ReportProductSales()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var productSales = _repository.GetProductSales(connection);
                _presenter.Report(productSales);
            }
        }
    }
}
