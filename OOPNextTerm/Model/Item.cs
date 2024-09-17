using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// ������ ������ � ������.
/// </summary>
class Item
{

    /// <summary>
    /// ���-�� �������.
    /// </summary>
    private static int _allItemsCount;

    /// <summary>
    /// ���������� � ����� ���-�� �������.
    /// </summary>
    public static int AllItemsCount
    {
        get
        {
            return _allItemsCount;
        }
    }

    /// <summary>
    /// ID ������.
    /// </summary>
    private int _id;

	/// <summary>
	/// ���������� ID ������.
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
	/// �������� ������.
	/// </summary>
	private string _name;

	/// <summary>
	/// ���������� � ����� �������� ������, ����������� � 200 ��������.
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
	/// ���������� � ������.
	/// </summary>
	private string _info;

	/// <summary>
	/// ���������� � ����� ���������� � ������, ����������� � 1000 ��������.
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
	/// ��������� ������.
	/// </summary>
	private double _cost;

	/// <summary>
	/// ���������� � ����� ������������ ����� �� 0 �� 100000 - ��������� ������.
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
	/// ������ ��������� ������ <see cref="Item"/>
	/// </summary>
	/// <param name="name">��������. �� 200 ��������.</param>
	/// <param name="info">��������. �� 1000 ��������.</param>
	/// <param name="cost">����. �� 0 �� 100000.</param>
	public Item(string name, string info, double cost)
	{
        Id = _allItemsCount;
        _allItemsCount ++;
		Name = name;
		Info = info;
		Cost = cost;
	}

	/// <summary>
	/// ����������� �� ���������. ������ ��������� ������ <see cref="Item"/>
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
