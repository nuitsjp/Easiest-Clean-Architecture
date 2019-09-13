using System.Linq;
using AdventureWorks.Sales.Entities;
using AdventureWorks.Sales.Presenters;
using Microsoft.Data.SqlClient;

namespace AdventureWorks.Sales.UseCases
{
    public class UseCase : IUseCase
    {
        private readonly IRepository _repository;

        private readonly IPresenter _presenter;

        private readonly string _connectionString;

        public UseCase(IPresenter presenter, IRepository repository, string connectionString)
        {
            _presenter = presenter;
            _repository = repository;
            _connectionString = connectionString;
        }

        public void ReportProductSales(string filePath)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var productSales = _repository.GetProductSales(connection);

                _presenter.Report(filePath, productSales);
            }
        }
    }
}
