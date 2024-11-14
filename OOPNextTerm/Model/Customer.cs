using OOPNextTerm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Хранит данные о покупателе.
/// </summary>
public class Customer
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
    private Address _address;

    /// <summary>
    /// Возвращает и задаёт адрес доставки покупателя, должен быть до 500 символов.
    /// </summary>
    public Address Address
    {
        get
        {
            return _address;
        }
        set
        {
            _address = value;
        }
    }

    /// <summary>
    /// Корзина товаров покупателя.
    /// </summary>
    private Cart _cart;

    /// <summary>
    /// Возвращает и задаёт корзину покупателя.
    /// </summary>
    public Cart Cart
    {
        get
        {
            return _cart;
        }
        set
        {
            _cart = value;
        }
    }

    /// <summary>
    /// Список заказов.
    /// </summary>
    private List<Order> _orders;

    public List<Order> Orders
    {
        get
        {
            return _orders;
        }
        set
        {
            _orders = value;
        }
    }

    /// <summary>
    /// Возвращает или меняет приоритет клиента.
    /// </summary>
    public bool IsPriority { get; set; }

    /// <summary>
    /// Список возможных скидок.
    /// </summary>
    public List<IDiscount> Discounts { get; set; }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Customer"/>
    /// </summary>
    /// <param name="fullName">Полное имя. До 200 символов.</param>
    /// <param name="address">Адрес доставки. До 500 символов.</param>
    public Customer(string fullName, Address address, Cart cart, List<Order> orders, bool isPriority)
    {
        Id = _allCustomersCount;
        _allCustomersCount++;
        FullName = fullName;
        Address = address;
        Cart = cart;
        Orders = orders;
        IsPriority = isPriority;
        Discounts = new List<IDiscount>();
        Discounts.Add(new PointsDiscount(0));
    }

    /// <summary>
    /// Конструктор по умолчанию. Создаёт экземпляр класса <see cref="Customer"/>
    /// </summary>
    public Customer()
    {
        Id = _allCustomersCount;
        _allCustomersCount++;
        FullName = " ";
        Address = new Address();
        Cart = new Cart();
        Orders = new List<Order>();
        IsPriority = false;
        Discounts = new List<IDiscount>();
        Discounts.Add(new PointsDiscount(0));
    }

    /// <summary>
    /// Переопределения отображения имени.
    /// </summary>
    /// <returns>Полное имя покупателя.</returns>
    public override string ToString()
    {
        return FullName;
    }
}