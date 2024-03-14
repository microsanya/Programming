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
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Wrong Value");
            }
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
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Wrong Value");
            }
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
}