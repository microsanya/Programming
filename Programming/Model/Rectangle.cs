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

    public Rectangle(double length, double width, string color)
    {
        Length = length;
        Width = width;
        Color = color;
    }

    public Rectangle()
    {
        Length = 0;
        Width = 0;
        Color = "";
    }
}