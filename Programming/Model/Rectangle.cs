class Rectangle
{
    private double _length;
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

    private double _width;
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

    public string Color { get; set; }
    public Point2D Center { get; set; }

    public Rectangle(double length, double width, string color, Point2D center)
    {
        Length = length;
        Width = width;
        Color = color;
        Center = center;
    }

    public Rectangle()
    {
        Length = 0;
        Width = 0;
        Color = "";
        Center = new Point2D(0, 0);
    }
}