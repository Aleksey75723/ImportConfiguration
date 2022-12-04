using System;

namespace ImportConfiguration
{
    /// <summary>
    ///     Класс импорта данных из файлов
    /// </summary>
    public class ImportData
    {
        /// <summary>
        ///     Директория папки
        /// </summary>
        public static string _mainPathFolder = ($"{Environment.CurrentDirectory}/");

        /// <summary>
        ///     Текущий считываемый файл
        /// </summary>
        public static string CurrentFile { set; get; }

        /// <summary>
        ///     Считывание файлов формата XML
        /// </summary>
        public void DeserializeXML()
        {
            ImportDataXml.DeserializeXMLMethod();
        }

        /// <summary>
        ///     Считывание файлов формата XML
        /// </summary>
        public void RegularExpressionsXML()
        {
            ImportDataXml.RegularExpressionsXMLMethod();
        }

        /// <summary>
        ///     Считывание файлов формата CSV
        /// </summary>
        public void ReadFileCSV()
        {
            ImportDataCsv.ImportFormatCSV();
        }
    }
}