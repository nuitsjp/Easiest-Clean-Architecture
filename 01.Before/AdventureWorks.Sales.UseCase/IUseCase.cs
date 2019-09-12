using System.Collections;
using System.Collections.Generic;
using AdventureWorks.Sales.Domain;

namespace AdventureWorks.Sales.UseCase
{
    public interface IUseCase
    {
        void ReportProductSales(string filePath);
    }
}