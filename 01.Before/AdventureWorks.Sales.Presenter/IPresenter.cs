using System;
using System.Collections.Generic;
using AdventureWorks.Sales.Domain;

namespace AdventureWorks.Sales.Presenter
{
    public interface IPresenter
    {
        void Report(string filePath, IEnumerable<ProductSales> productSales);
    }
}
