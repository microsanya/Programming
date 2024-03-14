class Song
{
    private int _id;
    public int Id
    {
        get
        {
            return _id;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Wrong value");
            }
            _id = value;
        }
    }

    public string Name { get; set; }
    public string Singer { get; set; }

    public Song (int id, string name, string singer)
    {
        Id = id;
        Name = name;
        Singer = singer;
    }

    public Song()
    {
        Id = 0;
        Name = "";
        Singer = "";
    }
}