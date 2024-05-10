/// <summary>
/// Хранит координаты точки на плоскости.
/// </summary>
class Point2D
{
    /// <summary>
    /// Координата абсциссы точки.
    /// </summary>
    private double _x;
    /// <summary>
    /// Возвращает и задает координату абсциссы точки. Должна быть только положительной.
    /// </summary>
    public double X
    {
        get
        {
            return _x;
        }
        private set
        {
            Validator.AssertOnPositiveValue(value);
            _x = value;
        }
    }

    /// <summary>
    /// Координата ординаты точки.
    /// </summary>
    private double _y;
    /// <summary>
    /// Возвращает и задает координату ординаты точки. Должна быть только положительной.
    /// </summary>
    public double Y
    {
        get
        {
            return _y;
        }
        private set
        {
            Validator.AssertOnPositiveValue(value);
            _y = value;
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Point2D"/>.
    /// </summary>
    /// <param name="x">Координата абсциссы. Должна быть положительной.</param>
    /// <param name="y">Координата ординаты. Должна быть положительной.</param>
    public Point2D (double x, double y)
    {
        _x = x;
        _y = y;
    }
}