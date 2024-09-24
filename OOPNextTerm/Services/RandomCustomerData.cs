using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Diagnostics.Metrics;


/// <summary>
/// Хранит в себе случайно сгенерированные данные для покупателей.
/// </summary>
public static class RandomCustomerData
{
    /// <summary>
    /// Случайные полные имена покупателей.
    /// </summary>
    public static readonly string[] FullNames =
    {
        "James Robert Anderson",
        "Emily Grace Johnson",
        "Michael Anthony Davis",
        "Sarah Elizabeth Miller",
        "Christopher John Wilson",
        "Amanda Rose Martinez",
        "Daniel Matthew Thompson",
        "Laura Marie Walker",
        "Joshua David Scott",
        "Jessica Lynn Garcia",
    };

    /// <summary>
    /// Случайные адреса покупателей.
    /// </summary>
    public static readonly string[] Addresses =
    {
        "1458 Maple Street, Springfield, IL 62701",
        "3427 Oak Lane, Denver, CO 80202",
        "2219 Elm Avenue, Austin, TX 7330",
        "5683 Pine Boulevard, Phoenix, AZ 85001",
        "9014 Birch Drive, Seattle, WA 98101",
        "7789 Willow Road, Orlando, FL 32801",
        "2307 Cedar Street, Portland, OR 97201",
        "5149 Aspen Lane, Boston, MA 02108",
        "3890 Sycamore Circle, Miami, FL 33101",
        "6721 Redwood Avenue, San Diego, CA 92101",
    };
}