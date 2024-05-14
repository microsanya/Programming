using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Text.RegularExpressions;

/// <summary>
/// Хранит в себе методы валидации целочисленных и вещественных значений.
/// </summary>
static class Validator
{
    /// <summary>
    /// Проверяет, что принимаемое целочисленное значение положительно.
    /// </summary>
    /// <param name="value">Проверяемое число.</param>
    /// <exception cref="ArgumentException">Неправильное значение в методе, оно должно быть положительным.</exception>
    public static void AssertOnPositiveValue(int value)
    {
        if (value < 0)
        {
            throw new ArgumentException($"Wrong value in {new StackTrace().GetFrame(1).GetMethod().Name}, it needs to be positive");
        }
    }

    /// <summary>
    /// Проверяет, что принимаемое вещественное значение положительно.
    /// </summary>
    /// <param name="value">Проверяемое число.</param>
    /// <exception cref="ArgumentException">Неправильное значение в методе, оно должно быть положительным.</exception>
    public static void AssertOnPositiveValue(double value)
    {
        if (value < 0)
        {
            throw new ArgumentException($"Wrong value in {new StackTrace().GetFrame(1).GetMethod().Name}, it needs to be positive");
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
    /// <summary>
    /// Проверяет, что проверяемая строка содержит только буквы.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <exception cref="ArgumentException">Строка должна содержать только буквы!</exception>
    public static void AssertStringContainsOnlyLetters(string value)
    {
        if (!Regex.IsMatch(value, "^[a-zA-Z]*$"))
        {
            throw new ArgumentException("String needs to contain only letters!");
        }
    }
}