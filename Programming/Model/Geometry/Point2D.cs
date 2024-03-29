class Point2D
{
    private double _x;
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

    private double _y;
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

    public Point2D (double x, double y)
    {
        _x = x;
        _y = y;
    }
}