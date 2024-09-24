using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Diagnostics.Metrics;


/// <summary>
/// Хранит в себе случайно сгенерированные данные для товаров.
/// </summary>
public static class RandomItemData
{
    /// <summary>
    /// Случайные названия товаров.
    /// </summary>
    public static readonly string[] Names =
    {
        "UltraPro Wireless Headphones",
        "EcoFlow Insulated Water Bottle",
        "SwiftCharge Portable Power Bank",
        "Lumina LED Desk Lamp",
        "VeloFit Smart Watch",
        "PureBreeze Air Purifier",
        "CozyHome Electric Blanket",
        "FreshBite Air Fryer",
        "PowerCore USB Charging Station",
        "ActiveWave Bluetooth Speaker",
    };

    /// <summary>
    /// Случайные описания товаров.
    /// </summary>
    public static readonly string[] Info =
    {
        "These high-quality wireless headphones deliver crystal-clear sound and active noise cancellation, ideal for travel, exercise or relaxation. " +
            "Lightweight and comfortable, with a long battery life.",

        "Double wall water bottle that keeps drinks hot for up to 12 hours and cold for up to 24 hours. " +
            "Ideal for hiking, office work or sports.",

        "This powerful 20,000mAh portable battery allows you to quickly charge your device wherever you are. " +
            "Compact and lightweight, perfect for travel.",

        "A dimmable desk lamp with a modern design. " +
            "Its soft lighting creates a cozy atmosphere for working, studying or reading.",

        "Smartwatch with activity tracking, sleep monitoring and smartphone notifications. " +
            "Waterproof and suitable for all types of training.",

        "A powerful air purifier that removes dust, allergens and odors. " +
            "Its quiet operation and modern design make it ideal for home and office use.",

        "Electric blanket with multiple heating modes and automatic shut-off system for maximum safety and comfort on cold days.",

        "An air fryer that allows you to cook healthy food with minimal oil. " +
            "It is ideal for frying, baking and reheating food.",

        "Station for simultaneous charging of up to five devices via USB. " +
            "Perfect for home, office or travel to stay connected.",

        "A wireless speaker with powerful sound and long battery life. " +
            "Its compact design makes it convenient for use at home or outdoors.",
    };

    /// <summary>
    /// Случайные стоимости товаров.
    /// </summary>
    public static readonly double[] Costs =
    {
        26.14,
        140.86,
        5144.29,
        5841.59,
        2934.61,
        5191.39,
        1085.79,
        969.60,
        6698.38,
        5772.50,
    };
}