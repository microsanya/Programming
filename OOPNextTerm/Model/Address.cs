
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using System;
using System.Xml.Linq;

/// <summary>
/// Хранит себе данные об одном адресе покупателя.
/// </summary>
public class Address
{
    /// <summary>
    /// Индекс
    /// </summary>
    private int _index;

    /// <summary>
    /// Возвращает и задаёт целое шестизначное число - значение индекса.
    /// </summary>
    public int Index
    {
        get
        {
            return _index;
        }
        set
        {
            //ValueValidator.AssertOnNeedNumberCount(value, 7);
            _index = value;
        }
    }


    /// <summary>
    /// Страна проживания.
    /// </summary>
    private string _country;

    /// <summary>
    /// Возвращает и задаёт строку длинной не более 50 символов - название страны.
    /// </summary>
    public string Country
    {
        get
        {
            return _country;
        }
        set
        {
            //ValueValidator.AssertOnNeedSize(value, 50, Country);
            _country = value;
        }
    }


    /// <summary>
    /// Город (населённый пункт).
    /// </summary>
    private string _city;

    /// <summary>
    /// Возвращает и задаёт строку длинной не более 50 символов - название города.
    /// </summary>
    public string City
    {
        get
        {
            return _city;
        }
        set
        {
            //ValueValidator.AssertOnNeedSize(value, 50, City);
            _city = value;
        }
    }


    /// <summary>
    /// Название улицы.
    /// </summary>
    private string _street;

    /// <summary>
    /// Возвращает и задаёт строку длинной не 100 символов - название улицы.
    /// </summary>
    public string Street
    {
        get
        {
            return _street;
        }
        set
        {
            //ValueValidator.AssertOnNeedSize(value, 100, Street);
            _street = value;
        }
    }


    /// <summary>
    /// Номер дома.
    /// </summary>
    private string _building;

    /// <summary>
    /// Возвращает и задаёт строку не более 10 символов - номер дома.
    /// </summary>
    public string Building
    {
        get
        {
            return _building;
        }
        set
        {
            //ValueValidator.AssertOnNeedSize(value, 10, Building);
            _building = value;
        }
    }


    /// <summary>
    /// Номер квартиры/помещения.
    /// </summary>
    private int _apartment;

    /// <summary>
    /// Возвращает и задаёт число не более 10 символов - номер квартиры/помещения.
    /// </summary>
    public int Apartment
    {
        get
        {
            return _apartment;
        }
        set
        {
            //ValueValidator.AssertOnNeedNumberCount(value, 10);
            _apartment = value;
        }
    }


    /// <summary>
    /// Создаёт экземпляр класса <see cref="Address"/>
    /// </summary>
    /// <param name="index">Почтовый индекс, целое шестизначное число.</param>
    /// <param name="country">Страна/регион, строка, не более 50 символов.</param>
    /// <param name="city">Город (населенный пункт), строка, не более 50 символов.</param>
    /// <param name="street">Улица, строка, не более 100 символов.</param>
    /// <param name="building">Номер дома, строка, не более 10 символов.</param>
    /// <param name="apartment">Номер квартиры/помещения, не более 10 символов.</param>
    public Address(int index, string country, string city, string street, string building, int apartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        Building = building;
        Apartment = apartment;
    }

    /// <summary>
    /// Конструктор по умолчанию. Создаёт экземпляр класса <see cref="Address"/>
    /// </summary>
    public Address()
    {
        Index = 000000;
        Country = " ";
        City = " ";
        Street = " ";
        Building = " ";
        Apartment = 0;
    }
}