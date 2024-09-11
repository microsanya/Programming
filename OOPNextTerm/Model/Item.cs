using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Хранит данные о товаре.
/// </summary>
class Item
{
    /// <summary>
    /// ID товара.
    /// </summary>
    private readonly int _id;

    /// <summary>
    /// Возвращает ID товара.
    /// </summary>
    public int Id
    {
        get 
        { 
            return _id; 
        }
    }

    /// <summary>
    /// Кол-во товаров.
    /// </summary>
    private static int _allItemsCount;

    /// <summary>
    /// Возвращает и задаёт кол-во товаров.
    /// </summary>
    public static int AllItemsCount
    {
        get
        {
            return _allItemsCount;
        }
    }
    /// <summary>
    /// Название товара.
    /// </summary>
    private string _name;

    /// <summary>
    /// Возвращает и задаёт название товара, ограничение в 200 символов.
    /// </summary>
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    /// <summary>
    /// Информация о товаре.
    /// </summary>
    private string _info;

    /// <summary>
    /// Возвращает и задаёт информацию о товаре, ограничение в 1000 символов.
    /// </summary>
    public string Info
    {
        get
        {
            return _info;
        }
        set
        {
            _info = value;
        }
    }

    /// <summary>
    /// Стоимость товара.
    /// </summary>
    private double _cost;

    /// <summary>
    /// Возвращает и задаёт вещественное число от 0 до 100000 - стоимость товара.
    /// </summary>
    public double Cost
    {
        get
        {
            return _cost;
        }
        set
        {
            _cost = value;
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Item"/>
    /// </summary>
    /// <param name="length">Длина. Должна быть только положительной.</param>
    public Item(string name, string info, double cost)
    {
        _allItemsCount += 1;
        Id = _allItemsCount;
        Name = name;
        Info = info;
        Cost = cost;
    }

    /// <summary>
    /// Конструктор по умолчанию. Создаёт экземпляр класса <see cref="Item"/>
    /// </summary>
    public Rectangle()
    {
        Id = _allItemsCount;
        Name = " ";
        Info = " ";
        Cost = 0;
    }
}
