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
        "627001,US,Springfield,Maple Street,1458/1,12",
        "802002,US,Denver,Oak Lane,3427/2,5",
        "733001,US,Austin,Elm Avenue,2219/1,8",
        "850001,US,Phoenix,Pine Boulevard,5683/3,15",
        "981001,US,Seattle,Birch Drive,9014/2,20",
        "328001,US,Orlando,Willow Road,7789/1,3",
        "972001,US,Portland,Cedar Street,2307/4,7",
        "021081,US,Boston,Aspen Lane,5149/1,11",
        "331001,US,Miami,Sycamore Circle,3890/5,9",
        "921001,US,San Diego, Redwood Avenue,6721/2,14",
    };
}