namespace ImportConfiguration
{
    /// <summary>
    ///     Данные конфигурации файла формата CSV
    /// </summary>
    public class ConfigurationsDataCSV: IDataCSV
    {
        public string Configuration { get; set; }

        public string DescriptionConfiguration { get; set; }
    }
}