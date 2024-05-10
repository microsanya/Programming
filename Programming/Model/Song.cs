/// <summary>
/// Хранит данные о песне.
/// </summary>
class Song
{
    /// <summary>
    /// Идентификатор песни.
    /// </summary>
    private int _id;
    /// <summary>
    /// Возвращает и задаёт идентификатор песни. Должен быть положительным.
    /// </summary>
    public int Id
    {
        get
        {
            return _id;
        }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _id = value;
        }
    }
    /// <summary>
    /// Возвращает и задаёт название песни.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Возвращает и задаёт имя исполнителя.
    /// </summary>
    public string Singer { get; set; }
    /// <summary>
    /// Создаёт экземпляр класса <see cref="Song"/>
    /// </summary>
    /// <param name="id">Идентификатор песни. Должен быть положительным. </param>
    /// <param name="name">Название песни.</param>
    /// <param name="singer">Имя исполнителя.</param>
    public Song (int id, string name, string singer)
    {
        Id = id;
        Name = name;
        Singer = singer;
    }
    /// <summary>
    /// Конструктор по умолчанию. Создаёт экземпляр класса <see cref="Song"/>
    /// </summary>
    public Song()
    {
        Id = 0;
        Name = "";
        Singer = "";
    }
}