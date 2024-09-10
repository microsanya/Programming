using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Text.RegularExpressions;

/// <summary>
/// Хранит в себе методы валидации целочисленных и вещественных значений, строковых значений.
/// </summary>
static class ValueValidator
{
    /// <summary>
    /// Проверяет, что принимаемое целочисленное значение положительно.
    /// </summary>
    /// <param name="value">Проверяемое число.</param>
    /// <exception cref="ArgumentException">Неправильное значение в методе, оно должно быть положительным.</exception>
    public static void AssertOnNeedSize(string value, int min, int max)
    {
        //if ( )
        //{
        //    throw new ArgumentException($"Wrong value in {new StackTrace().GetFrame(1).GetMethod().Name}, it needs to be positive");
        //}
    }
}