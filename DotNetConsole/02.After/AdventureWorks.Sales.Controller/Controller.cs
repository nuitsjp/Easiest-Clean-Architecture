using System;
using AdventureWorks.Sales.Presenter;
using AdventureWorks.Sales.UseCase;

namespace AdventureWorks.Sales.Controller
{
    public class Controller
    {
        private readonly IUseCase _useCase;

        public Controller(IUseCase useCase)
        {
            _useCase = useCase;
        }

        public void Report()
        {
            _useCase.ReportProductSales();
        }
    }
}
