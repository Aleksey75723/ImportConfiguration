using System;

namespace ImportConfiguration
{
    internal class Client
    {
        public void Main()
        {
            Console.WriteLine("Import XML");
            var importXML = new ImportData();
            importXML.DeserializeXML();
            importXML.RegularExpressionsXML();

            Console.WriteLine("Import CSV");
            var importCSV = new ImportData();
            importCSV.ReadFileCSV();


            Console.ReadLine();
        }
    }
}