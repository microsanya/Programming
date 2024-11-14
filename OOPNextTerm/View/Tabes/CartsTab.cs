using OOPNextTerm.Model;
using OOPNextTerm.View.Tabs;
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
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Инициализация вкладки.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Список товаров.
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
                if (value == null) return;
                _items = value;
                ItemsCartListBox.Items.AddRange(value.ToArray());
            }
        }

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает или задает список клиентов.
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                if (value == null) return;
                _customers = value;
                CustomersComboBox.Items.AddRange(value.ToArray());
            }
        }

        /// <summary>
        /// Возвращает текущего выбранного клиента из CustomerComboBox.
        /// </summary>
        private Customer CurrentCustomer
        {
            get
            {
                if (CustomersComboBox.SelectedIndex == -1 || CustomersComboBox.SelectedItem == null)
                {
                    return null;
                }
                return (Customer)CustomersComboBox.SelectedItem;
            }
        }
        /// <summary>
        /// Возвращает текущий выбранный товар в корзине клиента.
        /// </summary>
        private Item CurrentCartItem
        {
            get
            {
                if (CartListBox.SelectedIndex == -1 || CartListBox.SelectedItem == null)
                {
                    return null;
                }
                return (Item)CartListBox.SelectedItem;
            }
        }

        /// <summary>
        /// Возвращает текущий выбранный товар из списка доступных товаров.
        /// </summary>
        private Item? CurrentItem
        {
            get
            {
                if (ItemsCartListBox.SelectedIndex == -1 || ItemsCartListBox.SelectedItem == null)
                {
                    return null;
                }
                return (Item)ItemsCartListBox.SelectedItem;
            }
        }

        /// <summary>
        /// Обновляет список доступных скидок в CheckedListBox.
        /// Устанавливает флажки для всех скидок.
        /// </summary>
        private void UpdateDiscountsCheckedListBox()
        {
            DiscountsListBox.Items.Clear();
            if (CurrentCustomer == null)
            {
                return;
            }
            DiscountsListBox.Items.AddRange(CurrentCustomer.Discounts.ToArray());
            CheckAllItems();
            UpdateDiscountAndTotalAmount();
        }

        /// <summary>
        /// Устанавливает флажки для всех элементов в списке скидок.
        /// </summary>
        private void CheckAllItems()
        {
            for (int i = 0; i < DiscountsListBox.Items.Count; i++)
            {
                DiscountsListBox.SetItemChecked(i, true);
            }
        }

        /// <summary>
        /// Обновляет сумму скидки и итоговую сумму заказа.
        /// </summary>
        private void UpdateDiscountAndTotalAmount()
        {
            int discountAmount = 0;
            DAmountNum.Text = "0";
            TOTALNUM.Text = "0";
            if (CurrentCustomer == null)
            {
                return;
            }
            foreach (IDiscount discount in DiscountsListBox.CheckedItems)
            {
                discountAmount += (int)discount.Calculate(CurrentCustomer.Cart.Items);
            }
            DAmountNum.Text = discountAmount.ToString();
            TOTALNUM.Text = (CurrentCustomer.Cart.Amount - discountAmount).ToString();
        }

        /// <summary>
        /// Создает заказ, применяя выбранные скидки.
        /// Обновляет информацию о скидках и возвращает общую сумму скидки.
        /// </summary>
        /// <returns>Сумма примененных скидок.</returns>
        public int CreateOrder()
        {
            int discountAmount = 0;
            DAmountNum.Text = "0";
            TOTALNUM.Text = "0";
            if (CurrentCustomer == null)
            {
                return 0;
            }
            foreach (IDiscount discount in DiscountsListBox.CheckedItems)
            {
                discountAmount += (int)discount.Apply(CurrentCustomer.Cart.Items);
            }

            foreach (IDiscount discount in CurrentCustomer.Discounts)
            {
                discount.Update(CurrentCustomer.Cart.Items);
            }
            UpdateDiscountsCheckedListBox();
            return discountAmount;
        }

        /// <summary>
        /// Очищает все товары в корзине текущего клиента и CartItemsListBox.
        /// </summary>
        private void ClearCart()
        {
            if (CurrentCustomer != null)
            {
                CurrentCustomer.Cart.Items.Clear();
                CartListBox.Items.Clear();
            }
        }

        /// <summary>
        /// Обновляет информацию о сумме товаров в корзине и отображает ее в AmountLabel.
        /// </summary>
        private void UpdateAmount()
        {
            if (CurrentCustomer == null)
            {
                AmountTotalLabel.Text = "0.0";
                return;
            };
            AmountTotalLabel.Text = CurrentCustomer.Cart.Amount.ToString();
        }

        /// <summary>
        /// Обновление данных на вкладке.
        /// </summary>
        public void RefreshData()
        {
            if (Items != null)
            {
                ItemsCartListBox.Items.Clear();
                ItemsCartListBox.Items.AddRange(Items.ToArray());
            }
            if (Customers != null)
            {
                CustomersComboBox.Items.Clear();
                CustomersComboBox.Items.AddRange(Customers.ToArray());
            }
            CustomersComboBox.SelectedItem = null;
            CartListBox.Items.Clear();
            UpdateAmount();
        }

        /// <summary>
        /// Добавление в корзину
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer != null && CurrentItem != null)
            {
                CurrentCustomer.Cart.Items.Add(CurrentItem);
                CartListBox.Items.Add(CurrentItem);
            }
            UpdateAmount();
        }

        /// <summary>
        /// Удаление товара из корзины.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer != null && CurrentCartItem != null)
            {
                CurrentCustomer.Cart.Items.Remove(CurrentCartItem);
                CartListBox.Items.Remove(CurrentCartItem);
            }
            UpdateAmount();
        }

        /// <summary>
        /// Очистка корзины.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            ClearCart();
            UpdateAmount();
        }

        /// <summary>
        /// Создание заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null)
            {
                return;
            }
            if (CurrentCustomer.Cart.Items.Count < 1)
            {
                return;
            }

            if (CurrentCustomer.IsPriority == false)
            {
                double discountAmount = CreateOrder();
                Order order = new Order(DateTime.Now, CurrentCustomer.Address, CurrentCustomer.Cart.Items, OrderStatus.New, discountAmount);
                CurrentCustomer.Orders.Add(order);
            }
            else
            {
                double discountAmount = CreateOrder();
                Random rnd = new Random();
                PriorityOrder order = new PriorityOrder(DateTime.Now, CurrentCustomer.Address, CurrentCustomer.Cart.Items, OrderStatus.New, discountAmount, DateTime.Now, RandomCustomerData.OrderTimes[rnd.Next(6)]);
                CurrentCustomer.Orders.Add(order);
            }

            ClearCart();
            UpdateAmount();
        }

        /// <summary>
        /// Обработчик события изменения выбранного элемента в списке скидок.
        /// Обновляет скидку и общую сумму.
        /// </summary>
        private void DiscountsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDiscountAndTotalAmount();
        }
    }
}
