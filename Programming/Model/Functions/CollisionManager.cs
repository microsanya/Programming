static class CollisionManager
{
    public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
    {
        double dX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
        double dY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
        double diffWidth = Math.Abs(rectangle1.Width - rectangle2.Width)/2;
        double diffLength = Math.Abs(rectangle1.Length - rectangle2.Length)/2;
        return (dX < diffWidth) && (dY < diffLength);
    }

    public static bool IsCollision(Ring ring1,  Ring ring2) 
    { 
        double dX = Math.Abs(ring1.Center.X - ring2.Center.X);
        double dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
        double hypotenuse = Math.Sqrt(dX * dX + dY * dY);
        return hypotenuse < (ring1.ExternalRadius + ring2.ExternalRadius); 
    }
}