using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace ImportConfiguration
{
    /// <summary>
    ///     Класс импорта данных из файла формата XML
    /// </summary>
    internal class ImportDataXml: ImportData
    {
        public static void DeserializeXMLMethod()
        {
            foreach (var file in Directory.EnumerateFiles(_mainPathFolder, ($"*.xml")))
            {
                CurrentFile = file;

                var configurationXML = new ConfigurationsDataXML();

                var instanceDeserialize = new XmlSerializer(typeof(ConfigurationsDataXML));
                using (var streamReader = new StreamReader(CurrentFile))
                {
                    configurationXML = (ConfigurationsDataXML)instanceDeserialize.Deserialize(streamReader);
                }

                #region ConsoleInformationXML

                //вывод информации на конслоль
                Console.WriteLine($"\n{CurrentFile}");
                Console.WriteLine($"{configurationXML.Name}");
                Console.WriteLine($"{configurationXML.Description}");
                //вывод всех значений
                //var fields = configuration.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                //foreach (var field in fields)
                //{
                //    Console.WriteLine($"{field.GetValue(configuration)}");
                //}

                #endregion
            }

            Console.WriteLine($"\n");
        }


        public static void RegularExpressionsXMLMethod()
        {
            var stringArray = new List<string>() { "name", "description" }; //перечень конфигураций для считывания
            var result = string.Empty;
            string line;

            foreach (var file in Directory.EnumerateFiles(_mainPathFolder, ($"*.xml")))
            {
                CurrentFile = file;
                Console.WriteLine($"{CurrentFile}");

                var configurationXML = new ConfigurationsDataXML();

                using (var streamReader = new StreamReader(CurrentFile))
                {
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (stringArray.Any(line.Contains))
                        {
                            var regex = new Regex(@">(.*)<");
                            result = regex.Match(line).Groups[1].Value;

                            #region ConsoleInformationXML

                            //вывод информации на конслоль
                            //Console.WriteLine($"{CurrentFile}");
                            if (line.Contains("name"))
                            {
                                configurationXML.Name = result;
                                Console.WriteLine(result);
                            }

                            if (line.Contains("description"))
                            {
                                configurationXML.Description = result;
                                Console.WriteLine(result);
                            }

                            #endregion
                        }
                    }
                }

                Console.WriteLine($"\n");
            }
        }
    }
}