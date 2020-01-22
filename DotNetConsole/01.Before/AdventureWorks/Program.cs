using AdventureWorks.Sales;
using AdventureWorks.Sales.Controllers;
using AdventureWorks.Sales.Gateways;
using AdventureWorks.Sales.Presenters;
using AdventureWorks.Sales.UseCases;

namespace AdventureWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller =
                new Controller(
                    new UseCase(
                        new CsvPresenter(), 
                        new Repository(),
                        "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=AdventureWorks2017;Integrated Security=True;"));
            controller.Report("output.csv");
        }
    }
}
