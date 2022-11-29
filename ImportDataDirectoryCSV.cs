using System;
using Microsoft.VisualBasic.FileIO;

namespace ImportConfiguration
{
    /// <summary>
    ///     Класс импорта данных из файла формата CSV
    /// </summary>
    internal class ImportDataDirectoryCSV: DataDirectory
    {
        public static void ImportFormatCSV()
        {
            Console.WriteLine($"\n{currentFile}");
            using (var parser = new TextFieldParser(currentFile))
            {
                var delimiter = ";";
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(delimiter);

                var configurationsCSV = new ConfigurationsDataCSV();
                while (!parser.EndOfData)
                {
                    var fields = parser.ReadFields();
                    configurationsCSV.Name = fields[0];
                    configurationsCSV.Description = fields[1];

                    #region ConsoleInformationCSV

                    //вывод информации на конслоль
                    Console.WriteLine($"{configurationsCSV.Name} {configurationsCSV.Description}");
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