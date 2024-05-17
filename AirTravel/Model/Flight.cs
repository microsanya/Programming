using AirTravel.Properties;
using System.Diagnostics.Tracing;
using System.Numerics;
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
    /// Возвращает и задаёт время полёта. Величина должна быть находится в диапазоне от 0 до 1000.
    /// </summary>
    public int TimeFlight
    {
        get
        {
            return _timeFlight;
        }
        set
        {
            Validator.AssertValueInRange(value, 0, 1000);
            _timeFlight = value;
        }
    }

    /// <summary>
    /// Время вылета.
    /// </summary>
    private DateTime _departureTime;
    /// <summary>
    /// Возвращает и задаёт время вылета.
    /// </summary>
    public DateTime DepartureTime {
        get
        {
            return _departureTime;
        }
        set
        {
            if (value >= DateTime.Now)
            {
                _departureTime = value;
            }
            else
            {
                throw new ArgumentException("Wrong Time");
            }
        } 
    }

    /// <summary>
    /// Возвращает и задаёт тип перелёта.
    /// </summary>
    public FlightType FlightType { get; set; }

    /// <summary>
    /// Возвращает и задаёт логотип авиакомпании.
    /// </summary>
    public Image Airline { get; set; }

    /// <summary>
    /// Создаёт объект класса <see cref="Flight"/>.
    /// </summary>
    /// <param name="departurePoint">Пункт отправления.</param>
    /// <param name="destination">Пункт назначения.</param>
    /// <param name="timeFlight">Время полёта, должно быть от 0 до 1000.</param>
    /// <param name="departureTime">Дата отправления.</param>
    /// <param name="flightType">Тип полёта.</param>
    /// <param name="airlane">Логотип авиакомпании.</param>
    public Flight(string departurePoint, string destination, int timeFlight, DateTime departureTime, FlightType flightType, Image airlane)
    {
        DeparturePoint = departurePoint;
        Destination = destination;
        _timeFlight = timeFlight;
        DepartureTime = departureTime;
        FlightType = flightType;
        Airline = airlane;
    }

    /// <summary>
    /// Конструктор по умолчанию. Создаёт объект класса <see cref="Flight"/>.
    /// </summary>
    public Flight()
    {
        DeparturePoint = "";
        Destination = "";
        _timeFlight = 0;

        DateTime currentDate = DateTime.Now;
        DateTime nextDay = currentDate.AddDays(1);
        DepartureTime = nextDay;


        FlightType = FlightType.None;
        Airline = Resources.plane;
    }
}