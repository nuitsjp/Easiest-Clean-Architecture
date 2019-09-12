using AdventureWorks.Sales;
using AdventureWorks.Sales.Controller;
using AdventureWorks.Sales.Infrastructure;
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
                    new CsvPresenter("output.csv"),
                    new UseCase(
                        new Repository(),
                        "Data Source=localhost;Initial Catalog=AdventureWorks2017;Integrated Security=True;"));
            controller.Report();
        }
    }
}
