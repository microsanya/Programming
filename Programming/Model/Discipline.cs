/// <summary>
/// Хранит данные об учебной дисциплине.
/// </summary>
class Discipline
{
    /// <summary>
    /// Возвращает и задаёт название дисциплины.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Кол-во часов лекции.
    /// </summary>
    private int _lectureHours;
    /// <summary>
    /// Возвращает и задаёт кол-во часов лекции. Величина должна быть положительной.
    /// </summary>
    public int LectureHours
    {
        get
        {
            return _lectureHours;
        }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _lectureHours = value;
        }
    }
    /// <summary>
    /// Кол-во часов практики.
    /// </summary>
    private int _practiceHours;
    /// <summary>
    /// Возвращает и задаёт кол-во часов практики. Величина должна быть положительной.
    /// </summary>
    public int PracticeHours
    {
        get
        {
            return _practiceHours;
        }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _practiceHours = value;
        }
    }
    /// <summary>
    /// Создаёт экземпляр класса <see cref="Discipline"/>
    /// </summary>
    /// <param name="name">Название.</param>
    /// <param name="lectureHours">Кол-во часов лекций. Величина должна быть положительной.</param>
    /// <param name="practiceHours">Кол-во часов практики. Величина должна быть положительной.</param>
    public Discipline (string name, int lectureHours, int practiceHours)
    {
        Name = name;
        LectureHours = lectureHours;
        PracticeHours = practiceHours;
    }
    /// <summary>
    /// Конструктор по умолчанию. Создаёт экземпляр класса <see cref="Discipline"/>
    /// </summary>
    public Discipline()
    {
        Name = "";
        LectureHours = 0;
        PracticeHours = 0;
    }
}