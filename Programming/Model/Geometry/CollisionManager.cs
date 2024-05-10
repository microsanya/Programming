/// <summary>
/// Хранит в себе методы проверки на пересечение прямоугольников и колец.
/// </summary>
static class CollisionManager
{
    /// <summary>
    /// Проверяет, пересекаются ли два прямоугольника.
    /// </summary>
    /// <param name="rectangle1">Первый прямоугольник.</param>
    /// <param name="rectangle2">Второй прямоугольник.</param>
    /// <returns>Булевое значение, если пересекаются - true, иначе - false.</returns>
    public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
    {
        double dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
        double diffWidth = Math.Abs(rectangle1.Width + rectangle2.Width) / 2;
        double dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
        double diffLength = Math.Abs(rectangle1.Length + rectangle2.Length) / 2;
        return (dX < diffWidth) && (dY < diffLength);
    }

    /// <summary>
    /// Проверяет, пересекаются ли два кольца.
    /// </summary>
    /// <param name="ring1">Первое кольцо.</param>
    /// <param name="ring2">Второе кольцо.</param>
    /// <returns>Булевое значение, если пересекаются - true, иначе - false.</returns>
    public static bool IsCollision(Ring ring1,  Ring ring2) 
    { 
        double dX = Math.Abs(ring1.Center.X - ring2.Center.X);
        double dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
        double hypotenuse = Math.Sqrt(dX * dX + dY * dY);
        return hypotenuse < (ring1.ExternalRadius + ring2.ExternalRadius); 
    }
}