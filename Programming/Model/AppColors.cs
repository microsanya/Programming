static class AppColors
{
    // Validation-----------------------------------------------------------------------------------------
    private static System.Drawing.Color _standart = System.Drawing.Color.White;
    public static System.Drawing.Color Standart
    { 
        get
        {
            return _standart;
        }
    }

    private static System.Drawing.Color _error = System.Drawing.Color.LightPink;
    public static System.Drawing.Color Error
    {
        get 
        { 
            return _error; 
        }
    }

    // SeasonControl----------------------------------------------------------------------------------
    private static System.Drawing.Color _springColor = System.Drawing.Color.Green;
    public static System.Drawing.Color SpringColor
    {
        get
        {
            return _springColor;
        }
    }

    private static System.Drawing.Color _autumnColor = System.Drawing.Color.Orange;
    public static System.Drawing.Color AutumnColor
    {
        get
        {
            return _autumnColor;
        }
    }
    // Rectangle Color -----------------------------------------------------------
    private static System.Drawing.Color _normalRectangle = System.Drawing.Color.FromArgb(127, 127, 255, 127);
    public static System.Drawing.Color NormalRectangle
    {
        get
        {
            return _normalRectangle;
        }
    }
    private static System.Drawing.Color _collRectangle = System.Drawing.Color.FromArgb(127, 255, 127, 127);
    public static System.Drawing.Color CollRectangle
    {
        get
        {
            return _collRectangle;
        }
    }
}