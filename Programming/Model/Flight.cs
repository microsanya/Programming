﻿class Flight
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
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Wrong value");
            }
            _timeFlight = value;
        }
    }

    public Flight(string departurePoint, string destination, int timeFlight)
    {
        DeparturePoint = departurePoint;
        Destination = destination;
        _timeFlight = timeFlight;
    }
}