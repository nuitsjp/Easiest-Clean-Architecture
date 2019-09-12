using System.Collections.Generic;
using AdventureWorks.Sales.Entity;

namespace AdventureWorks.Sales.UseCase
{
    public interface IPresenter
    {
        void Report(IEnumerable<ProductSales> productSales);
    }
}
