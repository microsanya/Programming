/// <summary>
/// Хранит в себе алгоритм создания нового покупателя.
/// </summary>
static class CustomerFactory
{
    /// <summary>
    /// Создает новый товар типа Customer
    /// </summary>
    /// <returns>Новый экземпляр класса Customer</returns>
    public static Customer Randomize()
    {
        Random rnd = new Random();

        string customerFullName = RandomCustomerData.FullNames[rnd.Next(RandomCustomerData.FullNames.Length)];
        string customerAddress = RandomCustomerData.Addresses[rnd.Next(RandomCustomerData.Addresses.Length)];

        Customer newCustomer = new Customer(customerFullName, customerAddress);

        return newCustomer;
    }
}