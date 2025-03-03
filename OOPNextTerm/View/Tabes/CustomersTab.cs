using OOPNextTerm.Model;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOPNextTerm.View.Tabes
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Инициализация пользовательского элемента.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Закрытое поле, хранящее массив покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Возвращает и задает массив покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }

        /// <summary>
        /// Ранее созданный покупатель.
        /// </summary>
        private Customer _currentCustomer = new Customer();

        /// <summary>
        /// Список скидок, доступных клиенту.
        /// </summary>
        private List<IDiscount> _discounts;

        /// <summary>
        /// Получает или задает список скидок. При установке обновляет отображение скидок.
        /// </summary>
        public List<IDiscount> Discounts
        {
            get
            {
                return _discounts;
            }
            set
            {
                _discounts = value;
                UpdateDiscounts();
            }
        }

        /// <summary>
        /// Обновляет список скидок в интерфейсе.
        /// Если список пуст, добавляет накопительную скидку по умолчанию.
        /// </summary>
        private void UpdateDiscounts()
        {
            DiscountsListBox.Items.Clear();
            if (Discounts == null) return;
            if (Discounts.Count == 0)
            {
                Discounts.Add(new PointsDiscount(0));
            }
            DiscountsListBox.Items.AddRange(Discounts.ToArray());
        }

        /// <summary>
        /// Обновление данных в текстовых полях по указанному покупателю.
        /// </summary>
        /// <param name="customer">Сам покупатель.</param>
        private void UpdateCustomerInfo(Customer customer)
        {
            // ID
            CustomerIDTextBox.Text = Convert.ToString(customer.Id);
            // Full Name
            FullNameTextBox.Text = customer.FullName;
            //Priority
            if (customer.IsPriority == true)
            {
                PriorityCheck.Checked = true;
            }
            else
            {
                PriorityCheck.Checked = false;
            }
        }

        /// <summary>
        /// Добавление нового покупателя в CustomersListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Customer newCustomer = CustomerFactory.Randomize();
            _customers.Add(newCustomer);

            CustomersListBox.Items.Clear();

            foreach (var customer in _customers)
            {
                string addingString = $"ID: {customer.Id}; Full Name: {customer.FullName}";
                CustomersListBox.Items.Add(addingString);
            }
            CustomerDeliveryAddress.ClearForm();
        }

        /// <summary>
        /// Смена выбранного покупателя в CustomersListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex >= 0 && CustomersListBox.SelectedIndex < _customers.Count)
            {
                CustomerDeliveryAddress.ListBoxIsNull = false;
                int selectedCustomerNumber = CustomersListBox.SelectedIndex;
                _currentCustomer = _customers[selectedCustomerNumber];
                UpdateCustomerInfo(_currentCustomer);
                CustomerDeliveryAddress.UpdateData(_currentCustomer.Address);
                Discounts = _currentCustomer.Discounts;
            }
            else
            {
                CustomerDeliveryAddress.ListBoxIsNull = true;
                CustomerDeliveryAddress.ClearForm();
            }
        }

        /// <summary>
        /// Удаление покупателя из CustomersListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null)
            {
                int selectedIndex = CustomersListBox.SelectedIndex;
                _customers.RemoveAt(selectedIndex);

                CustomersListBox.Items.Clear();

                foreach (var customer in _customers)
                {
                    string addingCustomer = $"ID: {customer.Id}; Full Name: {customer.FullName}";
                    CustomersListBox.Items.Add(addingCustomer);
                }

                if (selectedIndex < CustomersListBox.Items.Count)
                {
                    CustomersListBox.SelectedIndex = selectedIndex;
                }
            }
        }

        /// <summary>
        /// Редактирование полного имени покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text.Length < 200)
            {
                FullNameTextBox.BackColor = System.Drawing.Color.White;
                _customers[CustomersListBox.SelectedIndex].FullName = FullNameTextBox.Text;
                Customer customer = _customers[CustomersListBox.SelectedIndex];
                CustomersListBox.Items[CustomersListBox.SelectedIndex] = $"ID: {customer.Id}; Full Name: {customer.FullName}";
            }
            else
            {
                FullNameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Прогрузка формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addressControl1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обрабатывает изменение приоритета клиента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PriorityCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                return;
            }

            _currentCustomer.IsPriority = PriorityCheck.Checked;
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки добавления скидки.
        /// Открывает форму для добавления новой скидки.
        /// </summary>
        private void AddDiscount_Click(object sender, EventArgs e)
        {
            if (Discounts == null)
            {
                return;
            }
            using (DiscountForm addDiscountForm = new DiscountForm())
            {
                if (addDiscountForm.ShowDialog() == DialogResult.OK)
                {
                    Discounts.Add(addDiscountForm.PercentDiscount);
                    DiscountsListBox.Items.Add(addDiscountForm.PercentDiscount);
                }
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки удаления скидки.
        /// Удаляет выбранную скидку из списка, если она не является накопительной.
        /// </summary>
        private void RemoveDiscount_Click(object sender, EventArgs e)
        {
            if (Discounts == null || DiscountsListBox.SelectedItem == null) 
            {
                return;
            }
            if (DiscountsListBox.SelectedItem is PointsDiscount)
            {
                MessageBox.Show("Нельзя удалить накопительную скидку!");
                return;
            }
            Discounts.Remove((IDiscount)DiscountsListBox.SelectedItem);
            DiscountsListBox.Items.Remove(DiscountsListBox.SelectedItem);
        }
    }
}
