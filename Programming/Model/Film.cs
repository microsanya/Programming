class Film
{
    public string Name { get; set; }

    private int _duration;
    public int Duration
    {
        get
        {
            return _duration;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Wrong value");
            }
            _duration = value;
        }
    }

    private int _year;

    public int Year
    {
        get
        {
            return _year;
        }
        set
        {
            if (value < 1900 || value > 2024)
            {
                throw new ArgumentOutOfRangeException("Wrong value");
            }
            _year = value;
        }
    }

    public string Genre { get; set; }

    private int _rating;
    public int Rating
    {
        get
        {
            return _rating;
        }
        set
        {
            if (value < 0 || value > 10)
            {
                throw new ArgumentOutOfRangeException("Wrong value");
            }
            _rating = value;
        }
    }

    public Film(string name, int duration, int year,  string genre, int rating)
    {
        Name = name;
        Duration = duration;
        Year = year;
        Genre = genre;
        Rating = rating;
    }
}