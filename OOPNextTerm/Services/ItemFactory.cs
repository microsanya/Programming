/// <summary>
/// Хранит в себе алгоритм создания нового товара.
/// </summary>
static class ItemFactory
{
    /// <summary>
    /// Создает новый товар типа Item
    /// </summary>
    /// <returns>Новый экземпляр класса Item</returns>
    public static Item Randomize()
    {
        Random rnd = new Random();
        int indexItemInfo = rnd.Next(RandomItemData.Names.Length);

        string itemName = RandomItemData.Names[indexItemInfo];
        string itemInfo = RandomItemData.Info[indexItemInfo];
        double itemCost = RandomItemData.Costs[rnd.Next(RandomItemData.Costs.Length)];
        Category category = (Category)indexItemInfo;

        Item newItem = new Item(itemName, itemInfo, itemCost, category);

        return newItem;
    }
}