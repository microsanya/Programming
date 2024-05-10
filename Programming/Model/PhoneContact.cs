/// <summary>
/// Хранит данные о контакте в телефоне.
/// </summary>
class PhoneContact
{
    /// <summary>
    /// Имя человека.
    /// </summary>
    private string _firstName;
    /// <summary>
    /// Возвращает и задаёт имя человека. Должно состоять только из букв.
    /// </summary>
    public string FirstName
    {
        get
        {
            return _firstName;
        }
        set
        {
            Validator.AssertStringContainsOnlyLetters(value);
            _firstName = value;
        }
    }
    /// <summary>
    /// Фамилия человека.
    /// </summary>
    private string _surname;
    /// <summary>
    /// Возвращает и задаёт фамилию человека. Должна состоять только из букв.
    /// </summary>
    public string Surname
    {
        get
        {
            return _surname;
        }
        set
        {
            Validator.AssertStringContainsOnlyLetters(value);
            _surname = value;
        }
    }
    /// <summary>
    /// Возвращает и задаёт номер телефона.
    /// </summary>
    public string PhoneNumber { get; set; }
    /// <summary>
    /// Создаёт экземпляр класса <see cref="PhoneContact"/>.
    /// </summary>
    /// <param name="firstName">Имя. Должно состоять только из букв.</param>
    /// <param name="lastName">Фамилия. Должна состоять только из букв.</param>
    /// <param name="phoneNumber">Номер телефона.</param>
    public PhoneContact (string firstName, string lastName, string phoneNumber)
    {
        _firstName = firstName;
        _surname = lastName;
        PhoneNumber = phoneNumber;
    }
    /// <summary>
    /// Конструктор по умолчанию. Создаёт экземпляр класса <see cref="PhoneContact"/>.
    /// </summary>
    public PhoneContact()
    {
        _firstName = "";
        Surname = "";
        PhoneNumber = "";
    }
}