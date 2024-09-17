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
    /// ID товара.
    /// </summary>
    private int _id;

	/// <summary>
	/// Возвращает ID товара.
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
			ValueValidator.AssertOnNeedSize(value, 200, Name);
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
			ValueValidator.AssertOnNeedSize(value, 1000, Info);
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
			ValueValidator.AssertValueInRange(value, 0, 100000);
			_cost = value;
		}
	}

	/// <summary>
	/// Создаёт экземпляр класса <see cref="Item"/>
	/// </summary>
	/// <param name="name">Название. До 200 символов.</param>
	/// <param name="info">Описание. До 1000 символов.</param>
	/// <param name="cost">Цена. От 0 до 100000.</param>
	public Item(string name, string info, double cost)
	{
        Id = _allItemsCount;
        _allItemsCount ++;
		Name = name;
		Info = info;
		Cost = cost;
	}

	/// <summary>
	/// Конструктор по умолчанию. Создаёт экземпляр класса <see cref="Item"/>
	/// </summary>
	public Item()
	{
		Id = _allItemsCount;
        _allItemsCount++;
        Name = " ";
		Info = " ";
		Cost = 0;
	}
}
