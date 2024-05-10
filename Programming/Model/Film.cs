/// <summary>
/// Хранит данные о фильме.
/// </summary>
class Film
{
    /// <summary>
    /// Возвращает и задаёт название фильма.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Продолжительность полёта.
    /// </summary>
    private int _duration;
    /// <summary>
    /// Возвращает и задаёт продолжительность фильма. Величина должна быть положительной.
    /// </summary>
    public int Duration
    {
        get
        {
            return _duration;
        }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _duration = value;
        }
    }
    /// <summary>
    /// Год выхода фильма.
    /// </summary>
    private int _year;
    /// <summary>
    /// Возвращает и задаёт год выхода фильма. Величина находиться в пределе от 1900 до 2024 года.
    /// </summary>
    public int Year
    {
        get
        {
            return _year;
        }
        set
        {
            Validator.AssertValueInRange(value, 1900, 2024);
            _year = value;
        }
    }

    /// <summary>
    /// Возвращает и задаёт жанр фильма.
    /// </summary>
    public string Genre { get; set; }

    /// <summary>
    /// Рейтинг фильма.
    /// </summary>
    private int _rating;
    /// <summary>
    /// Возвращает и задаёт рейтинг фильма. Должен быть в пределе от 0 до 10.
    /// </summary>
    public int Rating
    {
        get
        {
            return _rating;
        }
        set
        {
            Validator.AssertValueInRange(value, 0, 10);
            _rating = value;
        }
    }
    /// <summary>
    /// Создаёт экземпляр класса <see cref="Film"/>.
    /// </summary>
    /// <param name="name">Название фильма.</param>
    /// <param name="duration">Длительность фильма. Должна быть только положительной.</param>
    /// <param name="year">Год выпуска фильма. Должен быть от 1900 до 2024./param>
    /// <param name="genre">Жанр фильма.</param>
    /// <param name="rating">Рейтинг фильма. Должен быть от 0 до 10.</param>
    public Film(string name, int duration, int year,  string genre, int rating)
    {
        Name = name;
        Duration = duration;
        Year = year;
        Genre = genre;
        Rating = rating;
    }
    /// <summary>
    ///  Конструктор по умолчанию. Создаёт экземпляр класса <see cref="Film"/>.
    /// </summary>
    public Film ()
    {
        Name = "";
        Duration = 0;
        Year = 1900;
        Genre = "";
        Rating = 0;
    }
}