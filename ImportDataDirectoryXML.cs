using System;
using System.IO;
using System.Xml.Serialization;

namespace ImportConfiguration
{
    /// <summary>
    ///     Класс импорта данных из файла формата XML
    /// </summary>
    internal class ImportDataDirectoryXML: DataDirectory
    {
        public static void ImportFormatXML()
        {
            var configurationXML = new ConfigurationsDataXML();

            var instanceDeserialize = new XmlSerializer(typeof(ConfigurationsDataXML));
            using (var streamReader = new StreamReader(CurrentFile))
            {
                configurationXML = (ConfigurationsDataXML)instanceDeserialize.Deserialize(streamReader);
            }

            #region ConsoleInformationXML

            //вывод информации на конслоль
            Console.WriteLine($"{CurrentFile}");
            Console.WriteLine($"{configurationXML.Name}");
            Console.WriteLine($"{configurationXML.Description}");
            //вывод всех значений
            //var fields = configuration.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
            //foreach (var field in fields)
            //{
            //    Console.WriteLine($"{field.GetValue(configuration)}");
            //}

            Console.WriteLine($"\n");

            #endregion
        }
    }
}