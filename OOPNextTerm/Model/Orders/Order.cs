using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Хранит в себе данные о заказе.
/// </summary>
public class Order : IEquatable<Order>
{
    /// <summary>
    /// Кол-во заказов.
    /// </summary>
    private static int _allOrdersCount;

    /// <summary>
    /// Возвращает и задаёт кол-во заказов.
    /// </summary>
    public static int AllOrdersCount
    {
        get
        {
            return _allOrdersCount;
        }
    }

    /// <summary>
    /// ID заказа.
    /// </summary>
    private int _id;

    /// <summary>
    /// Возвращает ID заказа.
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
    /// Дата создания заказа.
    /// </summary>
    private DateTime _orderDate;

    /// <summary>
    /// Возвращает и задаёт дату создания заказа.
    /// </summary>
    public DateTime OrderDate
    {
        get
        {
            return _orderDate;
        }
        private set
        {
            _orderDate = value;
        }
    }

    /// <summary>
    /// Адрес доставки.
    /// </summary>
    public Address OrderAddress { get; set; }

    /// <summary>
    /// Список товаров.
    /// </summary>
    public List<Item> Items { get; set; }

    /// <summary>
    /// Общая стоимость.
    /// </summary>
    public double TotalAmount 
    { 
        get
        {
            double sum = 0;
            Items.ForEach(x => { sum += x.Cost; });
            return Math.Round(sum, 2);
        }
    }

    /// <summary>
    /// Размер скидки.
    /// </summary>
    double _discountAmount;

    /// <summary>
    /// Получает или задаёт размер скидки.
    /// </summary>
    public double DiscountAmount
    {
        get
        {
            return _discountAmount;
        }
        set
        {
            ValueValidator.AssertValueInRange(value, 0, 1000000000000000);
            _discountAmount = value;
        }
    }

    /// <summary>
    /// Получает стоимость заказа с применённой скидкой.
    /// </summary>
    public double Total
    {
        get
        {
            double total = TotalAmount - DiscountAmount;
            ValueValidator.AssertValueInRange(total, 0, 1000000000000000);
            return TotalAmount - DiscountAmount;
        }
    }

    /// <summary>
    /// Статус заказа.
    /// </summary>
    public OrderStatus OrderStatus { get; set; }

    /// <summary>
    /// Создает объект класса Создаёт экземпляр класса <see cref="Order"/>
    /// </summary>
    /// <param name="orderDate">Дата заказа.</param>
    /// <param name="orderAddress">Адрес заказа.</param>
    /// <param name="items">Список товаров.</param>
    /// <param name="orderStatus">Cтатус заказа.</param>
    /// <param name="discountAmount">Скидка.</param>
    public Order(DateTime orderDate, Address orderAddress, List<Item> items, OrderStatus orderStatus, double discountAmount)
    {
        Id = _allOrdersCount;
        _allOrdersCount++;
        OrderDate = orderDate;
        OrderAddress = orderAddress;
        Items = new List<Item>(items);
        OrderStatus = orderStatus;
        DiscountAmount = discountAmount;
    }

    /// <inheritdoc/>
    public bool Equals(Order? order2)
    {
        if (order2 == null)
        {     
            return false;
        }
        if (object.ReferenceEquals(this, order2))
        {
            return true;
        }
        return (Id == order2.Id);
    }
}
