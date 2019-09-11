using System.Collections;
using System.Collections.Generic;

namespace AdventureWorks.Sales.UseCase
{
    public interface IUseCase
    {
        IEnumerable<ProductSales> GerProductSales();
    }
}