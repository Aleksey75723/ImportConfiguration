using System.Xml.Serialization;

namespace ImportConfiguration
{
    /// <summary>
    ///     Данные конфигурации файла формата XML
    /// </summary>
    [XmlRoot("config")]
    public class ConfigurationsDataXML: IDataXML
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }
    }
}