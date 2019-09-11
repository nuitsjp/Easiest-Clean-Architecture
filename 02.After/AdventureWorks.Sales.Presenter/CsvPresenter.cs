using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using CsvHelper;

namespace AdventureWorks.Sales.Presenter
{
    public class CsvPresenter : IPresenter
    {
        private readonly string _filePath;

        public CsvPresenter(string filePath)
        {
            _filePath = filePath;
        }

        public void Report(IEnumerable<ProductSales> productSales)
        {
            using (var writer = new StreamWriter(_filePath))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(productSales);
            }
        }
    }
}