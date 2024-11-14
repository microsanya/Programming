using OOPNextTerm.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPNextTerm.View.Tabes
{
    public partial class PriorityOrdersTab : UserControl
    {
        public PriorityOrdersTab()
        {
            Random random = new Random();
            InitializeComponent();
            IDLabel.Text = "123";
            CreatedPicked.Value = DateTime.Now;
            UpdateTab();

            DelTimeComboBox.SelectedIndex = random.Next(RandomCustomerData.OrderTimes.Length);
        }

        /// <summary>
        /// Приоритетный заказ
        /// </summary>
        private PriorityOrder _priorityOrder;

        /// <summary>
        /// Получает и задаёт значение свойства приоритетного заказа.
        /// </summary>
        public PriorityOrder PriorityOrder
        {
            get
            {
                return _priorityOrder;
            }
            set
            {
                _priorityOrder = value;
            }
        }

        /// <summary>
        /// Список доступных товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Возвращает или задает список доступных товаров.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                _items = value;
            }
        }

        /// <summary>
        /// Обновляет информацию о сумме товаров в заказе и отображает ее в AmountLabel.
        /// </summary>
        private void UpdateAmount()
        {
            AmountLabel.Text = PriorityOrder.TotalAmount.ToString();
        }


        /// <summary>
        /// Очищает все товары в заказе и OrderItemsListBox.
        /// </summary>
        private void ClearOrder()
        {
            UpdateTab();
            PriorityOrder.Items.Clear();
            ItemsListBox.Items.Clear();
        }

        /// <summary>
        /// Обновляет данные во вкладке, создавая новый приоритетный заказ с предустановленными параметрами.
        /// </summary>
        private void UpdateTab()
        {
            Random rnd = new Random();
            string addressString = RandomCustomerData.Addresses[rnd.Next(RandomCustomerData.Addresses.Length)];
            string[] words = addressString.Split(',');
            int index = Convert.ToInt32(words[0]);
            string country = words[1];
            string city = words[2];
            string street = words[3];
            string building = words[4];
            int apartment = Convert.ToInt32(words[5]);
            Address customerAddress = new Address(index, country, city, street, building, apartment);

            Order order = new Order(DateTime.Now, customerAddress, new List<Item>(), OrderStatus.New, 0.0);
            PriorityOrder = new PriorityOrder(DateTime.Now, customerAddress, new List<Item>(), OrderStatus.New, 0.0, DateTime.Today, RandomCustomerData.OrderTimes[rnd.Next(6)]);
            IdTextBox.Text = PriorityOrder.Id.ToString();
            DeliveryAddressControl.UpdateData(customerAddress);
        }

        /// <summary>
        /// Добавление товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Item item = Items[random.Next(Items.Count)];
            PriorityOrder.Items.Add(item);
            ItemsListBox.Items.Add(item);
            UpdateAmount();
        }

        /// <summary>
        /// Удаление товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1 || ItemsListBox.SelectedItem == null)
            {
                return;
            }
            int index = ItemsListBox.SelectedIndex;
            Object item = ItemsListBox.SelectedItem;
            PriorityOrder.Items.Remove((Item)item);
            ItemsListBox.Items.RemoveAt(index);
            if (ItemsListBox.Items.Count - index <= 1)
            {
                ItemsListBox.SelectedIndex = ItemsListBox.Items.Count - 1;
            }
            else
            {
                ItemsListBox.SelectedIndex = index;
            }
            UpdateAmount();
        }

        /// <summary>
        /// Очистить корзину.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            PriorityOrder.Items = new List<Item>();
            ClearOrder();
            UpdateAmount();
        }

    }
}
