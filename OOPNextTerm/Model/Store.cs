using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Хранит данные о магазине.
/// </summary>
public class Store
{
    /// <summary>
    /// Массив товаров.
    /// </summary>
    private List<Item> _items;

    /// <summary>
    /// Возвращает и задаёт массив товаров.
    /// </summary>
    public List<Item> Items
    {
        get 
        { 
            return _items;
        }
        set
        {
            _items = value;
        }
    }

    /// <summary>
    /// Массив покупателей.
    /// </summary>
    private List<Customer> _customers;

    /// <summary>
    /// Возвращает и задаёт массив покупателей.
    /// </summary>
    public List<Customer> Customers
    {
        get
        {
            return _customers;
        }
        set
        {
            _customers = value;
        }
    }

    public Store()
    {
        Items = new List<Item>();
        Customers = new List<Customer>();
    }
}