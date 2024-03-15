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
            Validator.AssertOnPositiveValue(value);
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
            Validator.AssertValueInRange(value, 1900, 2024);
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
            Validator.AssertValueInRange(value, 0, 10);
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

    public Film ()
    {
        Name = "";
        Duration = 0;
        Year = 1900;
        Genre = "";
        Rating = 0;
    }
}