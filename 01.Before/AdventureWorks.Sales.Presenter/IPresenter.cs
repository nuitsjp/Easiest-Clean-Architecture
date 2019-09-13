using AdventureWorks.Sales.Entities;
using System.Collections.Generic;

namespace AdventureWorks.Sales.Presenters
{
    public interface IPresenter
    {
        void Report(string filePath, IEnumerable<ProductSales> productSales);
    }
}
