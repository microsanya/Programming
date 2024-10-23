using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Хранит данные о корзине товаров.
/// </summary>
public class Cart
{
    /// <summary>
    /// Список товаров в корзине.
    /// </summary>
    private List<Item> _items;

    /// <summary>
    /// Получает или задает список товаров в корзине.
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
    /// Задаёт общую стоимость товаров в корзине.
    /// </summary>
    public double Amount
    {
        get
        {
            double _amount = 0.0;
            if (_items != null)
            {
                foreach (Item item in _items)
                {
                    _amount += item.Cost;
                }
            }
            return _amount;
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Cart"/>
    /// </summary>
    /// <param name="items">Список товаров.</param>
    public Cart(List<Item> items)
    {
        Items = items;
    }

    /// <summary>
    /// Конструктор класса по умолчанию. Создаёт экземпляр класса <see cref="Cart"/>
    /// </summary>
    public Cart()
    {
        Items = new List<Item>();
    }
}