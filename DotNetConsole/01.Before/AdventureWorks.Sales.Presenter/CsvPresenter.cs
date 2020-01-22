using System.Collections.Generic;
using System.IO;
using AdventureWorks.Sales.Entities;
using CsvHelper;

namespace AdventureWorks.Sales.Presenters
{
    public class CsvPresenter : IPresenter
    {
        public void Report(string filePath, IEnumerable<ProductSales> productSales)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(productSales);
            }
        }
    }
}