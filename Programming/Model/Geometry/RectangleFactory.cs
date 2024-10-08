﻿/// <summary>
/// Хранит в себе алгоритм создания нового прямоугольника.
/// </summary>
static class RectangleFactory
{
    /// <summary>
    /// Создает новый прямоугольник типа Rectangle
    /// </summary>
    /// <returns>Новый экземпляр класса Rectangle</returns>
    public static Rectangle Randomize()
    {
        Random rnd = new Random();

        double recLength = rnd.Next(0, 200);
        double recWidth = rnd.Next(0, 200);
        string recColor = Convert.ToString((Color)rnd.Next(0, 6));
        Point2D recCenter = new Point2D(rnd.Next(0, 500), rnd.Next(0, 500));

        Rectangle newRectangle = new Rectangle(recLength, recWidth, recColor, recCenter, 0);

        return newRectangle;
    }
}
