using System;

namespace ImportConfiguration
{
    /// <summary>
    ///     Класс условий для выбора метода
    /// </summary>
    internal class SelectMethodsReading: DataDirectory
    {
        /// <summary>
        ///     Выбор метода для считывания файла
        /// </summary>
        /// <param name="format)"> Введеный пользователем формат </param>
        public static void FormatSelection(string format)
        {
            if (string.Equals(format, "xml", StringComparison.CurrentCultureIgnoreCase))
            {
                ImportDataDirectoryXML.ImportFormatXML();
            }
            else if (string.Equals(format, "csv", StringComparison.CurrentCultureIgnoreCase))
            {
                ImportDataDirectoryCSV.ImportFormatCSV();
            }
        }
    }
}
