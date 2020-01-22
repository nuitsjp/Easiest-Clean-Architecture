using AdventureWorks.Sales.UseCases;

namespace AdventureWorks.Sales.Controllers
{
    public class Controller
    {
        private readonly IUseCase _useCase;

        public Controller(IUseCase useCase)
        {
            _useCase = useCase;
        }

        public void Report(string filePath)
        {
            _useCase.ReportProductSales(filePath);
        }
    }
}
