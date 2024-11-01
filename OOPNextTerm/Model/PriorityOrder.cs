using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Хранит данные о приоритетном заказе.
/// </summary>
public class PriorityOrder : Order
{
    /// <summary>
    /// Необходимое время доставки.
    /// </summary>
    private DateTime _needOrderDate;

    /// <summary>
    /// Возвращает и задаёт необходимое время доставки.
    /// </summary>
    public DateTime NeedOrderDate
    {
        get
        {
            return _needOrderDate;
        }
        set
        {
            _needOrderDate = value;
        }
    }

    /// <summary>
    /// Желаемое время доставки.
    /// </summary>
    private string _orderTime;

    /// <summary>
    /// Возвращает и задаёт желаемое время доставки.
    /// </summary>
    public string OrderTime
    {
        get
        {
            return _orderTime;
        }
        set
        {
            _orderTime = value;
        }
    }
    public PriorityOrder(DateTime orderDate, Address orderAddress, List<Item> items, double totalAmount, OrderStatus orderStatus, DateTime needOrderDate, string orderTime) : base(orderDate, orderAddress, items, totalAmount, orderStatus)
    {
        NeedOrderDate = needOrderDate;
        OrderTime = orderTime;
    }
}