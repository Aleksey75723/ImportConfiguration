namespace ImportConfiguration
{
    /// <summary>
    ///     Данные конфигурации файла формата CSV
    /// </summary>
    public class ConfigurationsDataCSV: IData
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}