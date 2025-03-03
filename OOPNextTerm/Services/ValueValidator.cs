using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Text.RegularExpressions;

/// <summary>
/// Хранит в себе методы валидации целочисленных и вещественных значений, строковых значений.
/// </summary>
static class ValueValidator
{
    /// <summary>
    /// Проверяет, что принимаемая строка нужного размера.
    /// </summary>
    /// <param name="value">Проверяемая строка.</param>
    /// <param name="maxLength">Максимальная длина.</param>
    /// <param name="propertyName">Свойство.</param>
    /// <exception cref="ArgumentException">Значение свойства должно быть меньше заданного числа.</exception>
    public static void AssertOnNeedSize(string value, int maxLength, string propertyName)
    {
        if (value.Length > maxLength)
        {
            throw new ArgumentException($"{propertyName} needs to be less than {maxLength}");
        }
    }

    /// <summary>
    /// Проверяет, что принимаемое число нужного размера.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="needLength"></param>
    /// <exception cref="ArgumentException"></exception>
    public static void AssertOnNeedNumberCount(int value, int needLength)
    {
        string check = Convert.ToString(value);
        if (check.Length != needLength)
        {
            throw new ArgumentException($"Wrong value in {new StackTrace().GetFrame(1).GetMethod().Name}, it needs to be this size: {needLength}");
        }
    }

    /// <summary>
    /// Проверяет, что проверяемое целочисленное значение принадлежит определённому диапазону
    /// </summary>
    /// <param name="value">Проверяемое значение</param>
    /// <param name="min">Нижняя граница диапазона</param>
    /// <param name="max">Верхняя граница диапазона</param>
    /// <exception cref="ArgumentException">Неправильное значение в методе, оно должно быть внутри диапазона</exception>
    public static void AssertValueInRange(int value, int min, int max)
    {
        if ((value < min) || (value > max))
        {
            throw new ArgumentException($"Wrong value in {new StackTrace().GetFrame(1).GetMethod().Name}, it needs to be in range: {min} - {max}");
        }
    }

    /// <summary>
    /// Проверяет, что проверяемое вещественное значение принадлежит определённому диапазону
    /// </summary>
    /// <param name="value">Проверяемое значение</param>
    /// <param name="min">Нижняя граница диапазона</param>
    /// <param name="max">Верхняя граница диапазона</param>
    /// <exception cref="ArgumentException">Неправильное значение в методе, оно должно быть внутри диапазона</exception>
    public static void AssertValueInRange(double value, double min, double max)
    {
        if ((value < min) || (value > max))
        {
            throw new ArgumentException($"Wrong value in {new StackTrace().GetFrame(1).GetMethod().Name}, it needs to be in range: {min} - {max}");
        }
    }
}