using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Хранит данные о покупателе.
/// </summary>
class Customer
{
    /// <summary>
    /// Кол-во покупателей.
    /// </summary>
    private static int _allCustomersCount;

    /// <summary>
    /// Возвращает и задаёт кол-во покупателей.
    /// </summary>
    public static int AllCustomersCount
    {
        get
        {
            return _allCustomersCount;
        }
    }

    /// <summary>
    /// ID покупателя.
    /// </summary>
    private int _id;

    /// <summary>
    /// Возвращает ID покупателя.
    /// </summary>
    public int Id
    {
        get
        {
            return _id;
        }
        private set
        {
            _id = value;
        }
    }

    /// <summary>
    /// Полное имя покупателя.
    /// </summary>
    private string _fullName;

    /// <summary>
    /// Возвращает и задаёт имя покупателя. Должно быть до 200 символов.
    /// </summary>
    public string FullName
    {
        get
        {
            return _fullName;
        }
        set
        {
            ValueValidator.AssertOnNeedSize(value, 200, FullName);
            _fullName = value;
        }
    }

    /// <summary>
    /// Адрес доставки покупателя.
    /// </summary>
    private string _address;

    /// <summary>
    /// Возвращает и задаёт адрес доставки покупателя, должен быть до 500 символов.
    /// </summary>
    public string Address
    {
        get
        {
            return _address;
        }
        set
        {
            ValueValidator.AssertOnNeedSize(value, 500, Address);
            _address = value;
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Customer"/>
    /// </summary>
    /// <param name="fullName">Полное имя. До 200 символов.</param>
    /// <param name="address">Адрес доставки. До 500 символов.</param>
    public Customer(string fullName, string address)
    {
        Id = _allCustomersCount;
        _allCustomersCount++;
        FullName = fullName;
        Address = address;
    }

    /// <summary>
    /// Конструктор по умолчанию. Создаёт экземпляр класса <see cref="Customer"/>
    /// </summary>
    public Customer()
    {
        Id = _allCustomersCount;
        _allCustomersCount++;
        FullName = " ";
        Address = " ";
    }
}