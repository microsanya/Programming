class Flight
{
    public string DeparturePoint { get; set; }

    public string Destination { get; set; }

    private int _timeFlight;

    public int TimeFlight
    {
        get
        {
            return _timeFlight;
        }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _timeFlight = value;
        }
    }

    public Flight(string departurePoint, string destination, int timeFlight)
    {
        DeparturePoint = departurePoint;
        Destination = destination;
        _timeFlight = timeFlight;
    }

    public Flight()
    {
        DeparturePoint = "";
        Destination = "";
        _timeFlight = 0;
    }
}