using System;
using System.IO;

namespace ImportConfiguration
{
    /// <summary>
    ///     Базовый класс выбора файла для считывания
    /// </summary>
    public abstract class DataDirectory
    {
        /// <summary>
        ///     Текущий считываемый файл
        /// </summary>
        public static string currentFile { set; get; }

        /// <summary>
        ///     Выбор формата для считывания
        /// </summary>
        public static void ReadFormat(string fileFormat)
        {
            var mainPath = ($"{Environment.CurrentDirectory}/");

            foreach (var file in Directory.EnumerateFiles(mainPath, ($"*.{fileFormat}")))
            {
                currentFile = file;

                SelectMethodsReading.FormatSelection(fileFormat);
            }
        }
    }
}