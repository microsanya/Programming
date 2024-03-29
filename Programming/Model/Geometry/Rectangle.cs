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

    private static int _allRectanglesCount;
    public static int AllRectanglesCount
    {
        get
        {
            return _allRectanglesCount;
        }
    }

    private int _id;
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

    public Rectangle(double length, double width, string color, Point2D center, int id)
    {
        Length = length;
        Width = width;
        Color = color;
        Center = center;
        _allRectanglesCount += 1;
        Id = _allRectanglesCount;
    }

    public Rectangle()
    {
        Length = 0;
        Width = 0;
        Color = "";
        Center = new Point2D(0, 0);
        Id = _allRectanglesCount;
    }
}