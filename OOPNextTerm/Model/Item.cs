using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
- _name – строковое поле с названием товара, до 200 символов.
- _info – строковое поле с описанием товара, до 1 000 символов.
- _cost – вещественное поле со стоимостью товара, от 0 до 100 0
*/
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
}
