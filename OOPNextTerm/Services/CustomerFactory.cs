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

        string addressString = RandomCustomerData.Addresses[rnd.Next(RandomCustomerData.Addresses.Length)];
        string[] words = addressString.Split(',');
        int index = Convert.ToInt32(words[0]);
        string country = words[1];
        string city = words[2];
        string street = words[3];
        string building = words[4];
        int apartment = Convert.ToInt32(words[5]);
        Address customerAddress = new Address(index, country, city, street, building, apartment);

        Customer newCustomer = new Customer(customerFullName, customerAddress);

        return newCustomer;
    }
}