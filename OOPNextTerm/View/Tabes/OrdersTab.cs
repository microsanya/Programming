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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOPNextTerm.View.Tabes
{
    public partial class OrdersTab : UserControl
    {
        private List<Order> _orderList = new List<Order>();

        /// <summary>
        /// Выбранный заказ.
        /// </summary>
        private Order _selectedOrder;

        private PriorityOrder SelectedPriorityOrder { get; set; }

        /// <summary>
        /// Возвращает и задаёт текущий заказ.
        /// </summary>
        public Order SelectedOrder
        {
            get
            {
                return _selectedOrder;
            }
            set
            {
                if (value is PriorityOrder priority)
                {
                    Random rnd = new Random();
                    SelectedPriorityOrder = priority;
                    TimeLabel.Visible = true;
                    DeliveryTimeComboBox.Visible = true;
                    DeliveryTimeComboBox.SelectedIndex = rnd.Next(6);
                }
                _selectedOrder = value;
            }
        }

        /// <summary>
        /// Инициализация вкладки.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
            TimeLabel.Visible = false;
            DeliveryTimeComboBox.Visible = false;
        }

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Получает или задает список клиентов.
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
                UpdateOrders();
            }
        }

        /// <summary>
        /// Обновляет список заказов, привязанный к клиентам.
        /// </summary>
        public void UpdateOrders()
        {
            _orderList.Clear();

            foreach (var customer in _customers)
            {
                _orderList.AddRange(customer.Orders);
            }

            var allOrdersForDisplay = _orderList.Select(o => new
            {
                OrderID = o.Id,
                OrderTime = o.OrderDate,
                OrderStatus = o.OrderStatus,
                CustomerName = _customers.First(c => c.Orders.Contains(o)).FullName
            }).ToList();

            OrdersGridView.DataSource = allOrdersForDisplay;
        }

        /// <summary>
        /// Обновляет информацию о сумме товаров в корзине и отображает ее в AmountLabel.
        /// </summary>
        private void UpdateAmount()
        {
            if (SelectedOrder == null)
            {
                TotalCountLabel.Text = "0";
                return;
            };
            TotalCountLabel.Text = SelectedOrder.TotalAmount.ToString();
        }

        /// <summary>
        /// Обновление данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrdersGridView_SelectionChanged(object sender, EventArgs e)
        {

            if (OrdersGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = OrdersGridView.SelectedRows[0].Index;

                _selectedOrder = _orderList[selectedIndex];

                IdOrderTextBox.Text = Convert.ToString(SelectedOrder.Id);
                OrderDate.Value = SelectedOrder.OrderDate;
                StatusOrderComboBox.SelectedIndex = Convert.ToInt32(SelectedOrder.OrderStatus);
                OrderAddressControl.UpdateData(SelectedOrder.OrderAddress);
                TotalCountLabel.Text = Convert.ToString(SelectedOrder.TotalAmount);

                if (_selectedOrder is PriorityOrder priority)
                {
                    TimeLabel.Visible = true;
                    DeliveryTimeComboBox.Visible = true;
                    OrderDate.Value = _selectedOrder.OrderDate;

                    PriorityOrder curOrder = SelectedOrder as PriorityOrder;
                    DeliveryTimeComboBox.SelectedIndex = Array.IndexOf(RandomCustomerData.OrderTimes, curOrder.OrderTime);
                }
                else
                {
                    TimeLabel.Visible = false;
                    DeliveryTimeComboBox.Visible = false;
                }
            }
        }

        /// <summary>
        /// Изменение статуса заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatusOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedOrder != null)
            {
                SelectedOrder.OrderStatus = (OrderStatus)StatusOrderComboBox.SelectedIndex;
            }
        }

        /// <summary>
        /// Обновление данных.
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
            if (SelectedOrder != null)
            {
                IdOrderTextBox.Text = Convert.ToString(SelectedOrder.Id);
                OrderDate.Value = SelectedOrder.OrderDate;
                StatusOrderComboBox.SelectedIndex = Convert.ToInt32(SelectedOrder.OrderStatus);
                OrderAddressControl.UpdateData(SelectedOrder.OrderAddress);
                TotalCountLabel.Text = Convert.ToString(SelectedOrder.TotalAmount);

                if (SelectedOrder is PriorityOrder priority)
                {
                    TimeLabel.Visible = true;
                    DeliveryTimeComboBox.Visible = true;
                    OrderDate.Value = SelectedOrder.OrderDate;
                    PriorityOrder curOrder = SelectedOrder as PriorityOrder;
                    DeliveryTimeComboBox.SelectedIndex = Array.IndexOf(RandomCustomerData.OrderTimes, curOrder.OrderTime);
                }
            }
        }

        /// <summary>
        /// Изменение времени заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            PriorityOrder curOrder = SelectedOrder as PriorityOrder;
            string timeString = curOrder.OrderTime;

            int index = Array.IndexOf(RandomCustomerData.OrderTimes, timeString);
                
            DeliveryTimeComboBox.SelectedIndex = index;
        }
    }
}
