/// <summary>
/// Хранит данные о полёте.
/// </summary>
class Flight
{
    /// <summary>
    /// Возвращает и задаёт название пункта отправления.
    /// </summary>
    public string DeparturePoint { get; set; }
    /// <summary>
    /// Возвращает и задаёт название пункта назначения.
    /// </summary>
    public string Destination { get; set; }
    /// <summary>
    /// Время полёта.
    /// </summary>
    private int _timeFlight;
    /// <summary>
    /// Возвращает и задаёт время полёта. Величина должна быть положительной.
    /// </summary>
    public int TimeFlight
    {
        get
        {
            return _timeFlight;
        }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _timeFlight = value;
        }
    }
    /// <summary>
    /// Создаёт объект класса <see cref="Flight"/>.
    /// </summary>
    /// <param name="departurePoint">Пункт отправления.</param>
    /// <param name="destination">Пункт назначения.</param>
    /// <param name="timeFlight">Время полёта, должно быть положительное.</param>
    public Flight(string departurePoint, string destination, int timeFlight)
    {
        DeparturePoint = departurePoint;
        Destination = destination;
        _timeFlight = timeFlight;
    }
    /// <summary>
    /// Конструктор по умолчанию. Создаёт объект класса <see cref="Flight"/>.
    /// </summary>
    public Flight()
    {
        DeparturePoint = "";
        Destination = "";
        _timeFlight = 0;
    }
}