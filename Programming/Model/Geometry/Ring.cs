class Ring
{
    public Point2D Center { get; set; }

    private double _internalRadius;
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

    private double _externalRadius;
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

    private double _area;
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

    public Ring (Point2D center, double internalRadius, double externalRadius, double Area)
    {
        Center = center;
        InternalRadius = internalRadius;
        ExternalRadius = externalRadius;
        Area = Area;
    }

    public Ring ()
    {
        Center = new Point2D (0, 0);
        InternalRadius = 0;
        ExternalRadius = 1;
        Area = Area;
    }
}