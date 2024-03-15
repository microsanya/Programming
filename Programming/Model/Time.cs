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
            Validator.AssertValueInRange(value, 0, 23);
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
            Validator.AssertValueInRange(value, 0, 60);
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
            Validator.AssertValueInRange(value, 0, 60);
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