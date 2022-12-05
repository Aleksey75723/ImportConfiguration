using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace ImportConfiguration
{
    /// <summary>
    ///     Класс импорта данных из файла формата CSV
    /// </summary>
    internal class ImportDataCsv: ImportData
    {
        public static void ImportFormatCSV()
        {
            foreach (var file in Directory.EnumerateFiles(_mainPathFolder, ($"*.csv")))
            {
                CurrentFile = file;

                Console.WriteLine($"\n{CurrentFile}");
                using (var parser = new TextFieldParser(CurrentFile))
                {
                    var delimiter = ";";
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(delimiter);

                    var configurationsCSV = new ConfigurationsDataCSV();
                    while (!parser.EndOfData)
                    {
                        var fields = parser.ReadFields();
                        configurationsCSV.Configuration = fields[0];
                        configurationsCSV.DescriptionConfiguration = fields[1];

                        #region ConsoleInformationCSV

                        //вывод информации на конслоль
                        Console.WriteLine($"{configurationsCSV.Configuration}"
                                          + $" {configurationsCSV.DescriptionConfiguration}");
                        //вывод всех значений
                        //foreach (var field in fields)
                        //{
                        //    Console.WriteLine(field);
                        //}

                        #endregion
                    }
                }
            }
        }
    }
}