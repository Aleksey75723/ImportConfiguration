namespace ImportConfiguration
{
    /// <summary>
    ///     Интерфейс считываемых значений
    /// </summary>
    public interface IData
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