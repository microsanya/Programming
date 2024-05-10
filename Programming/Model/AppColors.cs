/// <summary>
/// Хранит в себе данные о цветах, использующихся в приложении.
/// </summary>
static class AppColors
{
    // Validation-----------------------------------------------------------------------------------------
    /// <summary>
    /// Обычный белый цвет.
    /// </summary>
    private static System.Drawing.Color _standart = System.Drawing.Color.White;
    /// <summary>
    /// Возвращает значение обычного белого цвета.
    /// </summary>
    public static System.Drawing.Color Standart
    { 
        get
        {
            return _standart;
        }
    }

    /// <summary>
    /// Светлый красный цвет для ошибок ввода.
    /// </summary>
    private static System.Drawing.Color _error = System.Drawing.Color.LightPink;
    /// <summary>
    /// Возвращает значение светлого красного цвета.
    /// </summary>
    public static System.Drawing.Color Error
    {
        get 
        { 
            return _error; 
        }
    }

    // SeasonControl----------------------------------------------------------------------------------
    /// <summary>
    /// Зелёный цвет для выбора "Весна" в SeasonControl.
    /// </summary>
    private static System.Drawing.Color _springColor = System.Drawing.Color.Green;
    /// <summary>
    /// Возвращает значение обычного зелёного цвета.
    /// </summary>
    public static System.Drawing.Color SpringColor
    {
        get
        {
            return _springColor;
        }
    }

    /// <summary>
    /// Оранжевый цвет для выбора "Осень" в SeasonControl.
    /// </summary>
    private static System.Drawing.Color _autumnColor = System.Drawing.Color.Orange;
    /// <summary>
    /// Возвращает значение обычного оранжевого цвета.
    /// </summary>
    public static System.Drawing.Color AutumnColor
    {
        get
        {
            return _autumnColor;
        }
    }

    // Rectangle Color -----------------------------------------------------------
    /// <summary>
    /// Зелёный цвет для непересекающегося прямоугольника.
    /// </summary>
    private static System.Drawing.Color _normalRectangle = System.Drawing.Color.FromArgb(127, 127, 255, 127);
    /// <summary>
    /// Возвращает значение светлого зелёного цвета.
    /// </summary>
    public static System.Drawing.Color NormalRectangle
    {
        get
        {
            return _normalRectangle;
        }
    }
    /// <summary>
    /// Красный цвет для пересекающегося прямоугольника.
    /// </summary>
    private static System.Drawing.Color _collRectangle = System.Drawing.Color.FromArgb(127, 255, 127, 127);
    /// <summary>
    /// Возвращает значение светлого красного цвета.
    /// </summary>
    public static System.Drawing.Color CollRectangle
    {
        get
        {
            return _collRectangle;
        }
    }
}