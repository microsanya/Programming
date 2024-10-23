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

namespace OOPNextTerm.View.Tabes
{
    public partial class OrdersTab : UserControl
    {
        private List<Order> _orderList = new List<Order>();

        /// <summary>
        /// Выбранный заказ.
        /// </summary>
        private Order _selectedOrder;

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
                _selectedOrder = value;
            }
        }

        /// <summary>
        /// Инициализация вкладки.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
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
            }
        }
    }
}
