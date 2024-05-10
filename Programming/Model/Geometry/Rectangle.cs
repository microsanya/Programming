/// <summary>
/// Хранит данные о прямоугольнике.
/// </summary>
class Rectangle
{
    /// <summary>
    /// Длина прямоугольника.
    /// </summary>
    private double _length;
    /// <summary>
    /// Возвращает и задаёт длину прямоугольника. Должна быть положительной.
    /// </summary>
    public double Length
    {
        get
        {
            return _length;
        }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _length = value;
        }
    }

    /// <summary>
    /// Ширина прямоугольника.
    /// </summary>
    private double _width;
    /// <summary>
    /// Возвращает и задаёт ширину прямоугольника. Должна быть положительной.
    /// </summary>
    public double Width
    {
        get
        {
            return _width;
        }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _width = value;
        }
    }

    /// <summary>
    /// Возвращает и задаёт цвет прямоугольника.
    /// </summary>
    public string Color { get; set; }
    /// <summary>
    /// Возвращает и задаёт координаты центра прямоугольника.
    /// </summary>
    public Point2D Center { get; set; }

    /// <summary>
    /// Количество всех прямоугольников, созданных классом.
    /// </summary>
    private static int _allRectanglesCount;
    /// <summary>
    /// Возвращает количество всех прямоугольников, созданных классом.
    /// </summary>
    public static int AllRectanglesCount
    {
        get
        {
            return _allRectanglesCount;
        }
    }

    /// <summary>
    /// Уникальный идентификатор для всех объектов данного класса.
    /// </summary>
    private int _id;
    /// <summary>
    /// Возвращает и идентификатор прямоугольника. Должен быть положительным.
    /// </summary>
    public int Id
    {
        get
        {
            return _id;
        }
        private set
        {
            Validator.AssertOnPositiveValue(value);
            _id = value;
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Rectangle"/>
    /// </summary>
    /// <param name="length">Длина. Должна быть только положительной.</param>
    /// <param name="width">Ширина. Должна быть только положительной.</param>
    /// <param name="color">Цвет.</param>
    /// <param name="center">Координаты центра прямоугольника.</param>
    /// <param name="id">Идентификатор прямоугольника. Должен быть только положительным.</param>
    public Rectangle(double length, double width, string color, Point2D center, int id)
    {
        Length = length;
        Width = width;
        Color = color;
        Center = center;
        _allRectanglesCount += 1;
        Id = _allRectanglesCount;
    }

    /// <summary>
    /// Конструктор по умолчанию. Создаёт экземпляр класса <see cref="Rectangle"/>
    /// </summary>
    public Rectangle()
    {
        Length = 0;
        Width = 0;
        Color = "";
        Center = new Point2D(0, 0);
        Id = _allRectanglesCount;
    }
}