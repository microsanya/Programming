/// <summary>
/// Хранит данные о кольце.
/// </summary>
class Ring
{
    /// <summary>
    /// Возвращает и задаёт координаты центра кольца.
    /// </summary>
    public Point2D Center { get; set; }

    /// <summary>
    /// Внутренний радиус.
    /// </summary>
    private double _internalRadius;
    /// <summary>
    /// Возвращает и задает внутренний радиус. Должен быть больше нуля и меньше внешнего радиуса.
    /// </summary>
    public double InternalRadius
    {
        get
        {
            return _internalRadius;
        }
        set
        {
            Validator.AssertValueInRange(value, 0, _externalRadius);
            _internalRadius = value;
        }
    }

    /// <summary>
    /// Внешний радиус.
    /// </summary>
    private double _externalRadius;
    /// <summary>
    /// Возвращает и задает внешний радиус. Должен быть больше внутреннего и меньше максимального значения типа Double.
    /// </summary>
    public double ExternalRadius
    {
        get
        {
            return _externalRadius;
        }
        set
        {
            Validator.AssertValueInRange(value, _internalRadius, Double.MaxValue);
            _externalRadius = value;
        }
    }

    /// <summary>
    /// Площадь.
    /// </summary>
    private double _area;
    /// <summary>
    /// Возращает и задает (считает) площадь кольца.
    /// </summary>
    public double Area
    {
        get
        {
            return _area;
        }
        private set
        {
            _area = 3.14 * ((_externalRadius * _externalRadius) - (_internalRadius * _internalRadius));
        }
    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Ring"/>.
    /// </summary>
    /// <param name="center">Координаты центра.</param>
    /// <param name="internalRadius">Внутренний радиус. Должен быть больше нуля и меньше внешнего радиуса.</param>
    /// <param name="externalRadius">Внешний радиус. Должен быть больше внутреннего и меньше максимального значения типа Double.</param>
    /// <param name="Area">Площадь кольца.</param>
    public Ring (Point2D center, double internalRadius, double externalRadius, double Area)
    {
        Center = center;
        InternalRadius = internalRadius;
        ExternalRadius = externalRadius;
        Area = Area;
    }

    /// <summary>
    /// Конструктор по умолчанию. Создает экземпляр класса <see cref="Ring"/>.
    /// </summary>
    public Ring ()
    {
        Center = new Point2D (0, 0);
        InternalRadius = 0;
        ExternalRadius = 1;
        Area = Area;
    }
}