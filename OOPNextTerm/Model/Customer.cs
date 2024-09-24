using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// ������ ������ � ����������.
/// </summary>
class Customer
{
    /// <summary>
    /// ���-�� �����������.
    /// </summary>
    private static int _allCustomersCount;

    /// <summary>
    /// ���������� � ����� ���-�� �����������.
    /// </summary>
    public static int AllCustomersCount
    {
        get
        {
            return _allCustomersCount;
        }
    }

    /// <summary>
    /// ID ����������.
    /// </summary>
    private int _id;

    /// <summary>
    /// ���������� ID ����������.
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
    /// ������ ��� ����������.
    /// </summary>
    private string _fullName;

    /// <summary>
    /// ���������� � ����� ��� ����������. ������ ���� �� 200 ��������.
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
    /// ����� �������� ����������.
    /// </summary>
    private string _address;

    /// <summary>
    /// ���������� � ����� ����� �������� ����������, ������ ���� �� 500 ��������.
    /// </summary>
    public string Address
    {
        get
        {
            return _address;
        }
        set
        {
            ValueValidator.AssertOnNeedSize(value, 500, Address);
            _address = value;
        }
    }

    /// <summary>
    /// ������ ��������� ������ <see cref="Customer"/>
    /// </summary>
    /// <param name="fullName">������ ���. �� 200 ��������.</param>
    /// <param name="address">����� ��������. �� 500 ��������.</param>
    public Customer(string fullName, string address)
    {
        Id = _allCustomersCount;
        _allCustomersCount++;
        FullName = fullName;
        Address = address;
    }

    /// <summary>
    /// ����������� �� ���������. ������ ��������� ������ <see cref="Customer"/>
    /// </summary>
    public Customer()
    {
        Id = _allCustomersCount;
        _allCustomersCount++;
        FullName = " ";
        Address = " ";
    }
}