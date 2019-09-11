using System;
using AdventureWorks.Sales.Presenter;
using AdventureWorks.Sales.UseCase;

namespace AdventureWorks.Sales.Controller
{
    public class Controller
    {
        private readonly IPresenter _presenter;
        private readonly IUseCase _useCase;

        public Controller(IPresenter presenter, IUseCase useCase)
        {
            _presenter = presenter;
            _useCase = useCase;
        }

        public void Report()
        {
            var productSales = _useCase.GerProductSales();
            _presenter.Report(productSales);
        }
    }
}
