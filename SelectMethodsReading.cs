namespace ImportConfiguration
{
    /// <summary>
    ///     Класс условий для выбора метода
    /// </summary>
    internal class SelectMethodsReading: DataDirectory
    {
        /// <summary>
        ///     Выбор метода для считывания
        /// </summary>
        /// <param name="format)"> Введеный пользователем формат </param>
        public static void FormatSelection(string format)
        {
            if (format == "xml")
            {
                ImportDataDirectoryXML.ImportFormatXML();
            }
            else if (format == ("csv"))
            {
                ImportDataDirectoryCSV.ImportFormatCSV();
            }
        }
    }
}