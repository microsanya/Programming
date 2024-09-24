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
        /// Ранее созданный покупатель.
        /// </summary>
        private Customer _currentCustomer = new Customer();

        /// <summary>
        /// Обновление данных в текстовых полях по указанному товару.
        /// </summary>
        /// <param name="item">Сам товар.</param>
        private void UpdateCustomerInfo(Customer customer)
        {
            // ID
            CustomerIDTextBox.Text = Convert.ToString(customer.Id);
            // Full Name
            FullNameTextBox.Text = customer.FullName;
            // Address
            AddressTextBox.Text = customer.Address;
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
                int selectedCustomerNumber = CustomersListBox.SelectedIndex;
                _currentCustomer = _customers[selectedCustomerNumber];
                UpdateCustomerInfo(_currentCustomer);
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
        /// Редактирование адреса покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddressTextBox.Text.Length < 500)
            {
                AddressTextBox.BackColor = System.Drawing.Color.White;
                _customers[CustomersListBox.SelectedIndex].Address = AddressTextBox.Text;
                Customer customer = _customers[CustomersListBox.SelectedIndex];
                CustomersListBox.Items[CustomersListBox.SelectedIndex] = $"ID: {customer.Id}; Full Name: {customer.FullName}";
            }
            else
            {
                AddressTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
    }
}
