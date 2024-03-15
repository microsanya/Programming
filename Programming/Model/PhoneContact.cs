using System.Text.RegularExpressions;
class PhoneContact
{
    private bool AssertStringContainsOnlyLetters(string value)
    {
        if (!Regex.IsMatch(value, "^[a-zA-Z]*$"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private string _firstName;
    public string FirstName
    {
        get
        {
            return _firstName;
        }
        set
        {
            if (AssertStringContainsOnlyLetters(value) == false)
            {
                throw new ArgumentException("Wrong name");
            }
            _firstName = value;
        }
    }

    private string _surname;
    public string Surname
    {
        get
        {
            return _surname;
        }
        set
        {
            if (AssertStringContainsOnlyLetters(value) == false)
            {
                throw new ArgumentException("Wrong surname");
            }
            _surname = value;
        }
    }
    public string PhoneNumber { get; set; }

    public PhoneContact (string firstName, string lastName, string phoneNumber)
    {
        _firstName = firstName;
        _surname = lastName;
        PhoneNumber = phoneNumber;
    }

    public PhoneContact()
    {
        _firstName = "";
        Surname = "";
        PhoneNumber = "";
    }
}