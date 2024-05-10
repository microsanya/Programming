/// <summary>
/// Хранит данные о времени.
/// </summary>
class Time
{
    /// <summary>
    /// Кол-во часов.
    /// </summary>
    private int _hours;
    /// <summary>
    /// Возвращает и задаёт кол-во часов. Должно быть в пределе от 0 до 23.
    /// </summary>
    public int Hours
    {
        get
        {
            return _hours;
        }
        set
        {
            Validator.AssertValueInRange(value, 0, 23);
            _hours = value;
        }
    }
    /// <summary>
    /// Кол-во минут.
    /// </summary>
    private int _minutes;
    /// <summary>
    /// Возвращает и задаёт кол-во минут. Должно быть в пределе от 0 до 60.
    /// </summary>
    public int Minutes
    {
        get
        {
            return _minutes;
        }
        set
        {
            Validator.AssertValueInRange(value, 0, 60);
            _minutes = value;
        }
    }
    /// <summary>
    /// Кол-во секунд.
    /// </summary>
    private int _seconds;
    /// <summary>
    ///  Возвращает и задаёт кол-во секунд. Должно быть в пределе от 0 до 60.
    /// </summary>
    public int Seconds
    {
        get
        {
            return _seconds;
        }
        set
        {
            Validator.AssertValueInRange(value, 0, 60);
            _seconds = value;
        }
    }
    /// <summary>
    /// Создаёт экземпляр класса <see cref="Time"/>
    /// </summary>
    /// <param name="hours">Кол-во часов. Должно быть в пределе от 0 до 23.</param>
    /// <param name="minutes">Кол-во минут. Должно быть в пределе от 0 до 60.</param>
    /// <param name="seconds">Кол-во секунд. Должно быть в пределе от 0 до 60.</param>
    public Time (int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }
    /// <summary>
    /// Конструктор по умолчанию. Создаёт экземпляр класса <see cref="Time"/>
    /// </summary>
    public Time()
    {
        Hours = 0;
        Minutes = 0;
        Seconds = 0;
    }
}