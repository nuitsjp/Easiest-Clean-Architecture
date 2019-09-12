using AdventureWorks.Sales;
using AdventureWorks.Sales.Controller;
using AdventureWorks.Sales.Domain;
using AdventureWorks.Sales.Presenter;
using AdventureWorks.Sales.UseCase;

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
