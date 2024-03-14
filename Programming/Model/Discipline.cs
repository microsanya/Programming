class Discipline
{
    public string Name;
    private int _lectureHours;
    public int LectureHours
    {
        get
        {
            return _lectureHours;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Wrong value");
            }
            _lectureHours = value;
        }
    }
    private int _practiceHours;
    public int PracticeHours
    {
        get
        {
            return _practiceHours;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Wrong value");
            }
            _practiceHours = value;
        }
    }

    public Discipline (string name, int lectureHours, int practiceHours)
    {
        Name = name;
        LectureHours = lectureHours;
        PracticeHours = practiceHours;
    }

    public Discipline()
    {
        Name = "";
        LectureHours = 0;
        PracticeHours = 0;
    }
}