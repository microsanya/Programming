using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Хранит в себе данные о заказе.
/// </summary>
public class Order
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
    /// Статус заказа.
    /// </summary>
    public OrderStatus OrderStatus { get; set; }

    /// <summary>
    /// Создает объект класса Создаёт экземпляр класса <see cref="Order"/>
    /// </summary>
    /// <param name="orderDate">Дата заказа.</param>
    /// <param name="orderAddress">Адрес заказа.</param>
    /// <param name="items">Список товаров.</param>
    /// <param name="totalAmount">Общая сумма.</param>
    /// <param name="orderStatus">Cтатус заказа.</param>
    public Order(DateTime orderDate, Address orderAddress, List<Item> items, double totalAmount, OrderStatus orderStatus)
    {
        Id = _allOrdersCount;
        _allOrdersCount++;
        OrderDate = orderDate;
        OrderAddress = orderAddress;
        Items = new List<Item>(items);
        OrderStatus = orderStatus;
    }
}
