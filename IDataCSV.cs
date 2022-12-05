namespace ImportConfiguration
{
    /// <summary>
    ///     Интерфейс формата CSV
    /// </summary>
    public interface IDataCSV
    {
        /// <summary>
        ///     Конфигурация
        /// </summary>
        string Configuration { get; set; }


        /// <summary>
        ///     Описание конфигурации
        /// </summary>
        string DescriptionConfiguration { get; set; }
    }
}