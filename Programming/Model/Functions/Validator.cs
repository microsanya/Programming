using System.Runtime.InteropServices;
using System.Diagnostics;

static class Validator
{
    // проверка целочисленных значений на положительность
    public static void AssertOnPositiveValue(int value)
    {
        if (value < 0)
        {
            throw new ArgumentException($"Wrong vale in {new StackTrace().GetFrame(1).GetMethod().Name}, it needs to be positive");
        }
    }
    // проверка вещественных значений на положительность
    public static void AssertOnPositiveValue(double value)
    {
        if (value < 0)
        {
            throw new ArgumentException($"Wrong vale in {new StackTrace().GetFrame(1).GetMethod().Name}, it needs to be positive");
        }
    }
    // проверка на принадлежность диапазону (целочисленные значения)
    public static void AssertValueInRange(int value, int min, int max)
    {
        if ((value < min) || (value > max))
        {
            throw new ArgumentException($"Wrong vale in {new StackTrace().GetFrame(1).GetMethod().Name}, it needs to be in range: {min} - {max}");
        }
    }

    public static void AssertValueInRange(double value, double min, double max)
    {
        if ((value < min) || (value > max))
        {
            throw new ArgumentException($"Wrong vale in {new StackTrace().GetFrame(1).GetMethod().Name}, it needs to be in range: {min} - {max}");
        }
    }
}