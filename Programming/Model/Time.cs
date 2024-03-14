class Time
{
    private int _hours;
    public int Hours
    {
        get
        {
            return _hours;
        }
        set
        {
            if (value < 0 || value > 23)
            {
                throw new ArgumentOutOfRangeException("Wrong value");
            }
            _hours = value;
        }
    }

    private int _minutes;
    public int Minutes
    {
        get
        {
            return _minutes;
        }
        set
        {
            if (value < 0 || value> 60)
            {
                throw new ArgumentOutOfRangeException("Wrong value");
            }
            _minutes = value;
        }
    }

    private int _seconds;
    public int Seconds
    {
        get
        {
            return _seconds;
        }
        set
        {
            if (value < 0 || value > 60)
            {
                throw new ArgumentOutOfRangeException("Wrong value");
            }
            _seconds = value;
        }
    }

    public Time (int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    public Time()
    {
        Hours = 0;
        Minutes = 0;
        Seconds = 0;
    }
}