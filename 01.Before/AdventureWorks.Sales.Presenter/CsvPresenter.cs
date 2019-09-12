using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using CsvHelper;

namespace AdventureWorks.Sales.Presenter
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