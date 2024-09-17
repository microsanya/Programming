using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPNextTerm.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Инициализация формы.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Закрытое поле, хранящее массив товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();
        /// <summary>
        /// Ранее созданный товар.
        /// </summary>
        private Item _currentItem = new Item();

        /// <summary>
        /// Обновление данных в текстовых полях по указанному товару.
        /// </summary>
        /// <param name="item">Сам товар.</param>
        private void UpdateItemInfo(Item item)
        {
            // ID
            IdTextBox.Text = Convert.ToString(item.Id);
            // Cost
            CostTextBox.Text = Convert.ToString(item.Cost);
            // Name
            NameTextBox.Text = item.Name;
            // Description
            DescriptionTextBox.Text = item.Info;
        }

        /// <summary>
        /// Добавление товара с помощью кнопки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Item newItem = new Item();
            _items.Add(newItem);

            ItemsListBox.Items.Clear();

            foreach (var item in _items)
            {
                string addingString = $"ID: {item.Id}; Cost: {item.Cost}; Name: {item.Name}";
                ItemsListBox.Items.Add(addingString);
            }
        }

        /// <summary>
        /// Выбор товара в ItemsListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != null)
            {
                int selectedItemNumber = ItemsListBox.SelectedIndex;
                _currentItem = _items[selectedItemNumber];
                UpdateItemInfo(_currentItem);
            }
        }

        /// <summary>
        /// Удаление товара с помощью кнопки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                int selectedIndex = ItemsListBox.SelectedIndex;
                _items.RemoveAt(selectedIndex);

                ItemsListBox.Items.Clear();

                foreach (var item in _items)
                {
                    string addingFlight = $"ID: {item.Id}; Cost: {item.Cost}; Name: {item.Name}";
                    ItemsListBox.Items.Add(addingFlight);
                }

                if (selectedIndex < ItemsListBox.Items.Count)
                {
                    ItemsListBox.SelectedIndex = selectedIndex;
                }
            }
        }

        /// <summary>
        /// Изменение поля CostTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(CostTextBox.Text) > 0)
                {
                    CostTextBox.BackColor = System.Drawing.Color.White;
                    _items[ItemsListBox.SelectedIndex].Cost = Convert.ToDouble(CostTextBox.Text);
                    Item item = _items[ItemsListBox.SelectedIndex];
                    ItemsListBox.Items[ItemsListBox.SelectedIndex] = $"ID: {item.Id}; Cost: {item.Cost}; Name: {item.Name}";
                }
            }
            catch
            {
                CostTextBox.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}
