namespace ImportConfiguration
{
    /// <summary>
    ///     Интерфейс формата XML
    /// </summary>
    public interface IDataXML
    {
        /// <summary>
        ///     Название считываемого элемента
        /// </summary>
        string Name { get; set; }


        /// <summary>
        ///     Описание считываемого элемента
        /// </summary>
        string Description { get; set; }
    }
}