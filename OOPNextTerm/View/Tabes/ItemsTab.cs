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
        /// Возвращает и задаёт массив товаров.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }
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
            // Category
            CategoryComboBox.SelectedIndex = Convert.ToInt32(item.ItemCategory);
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
            Item newItem = ItemFactory.Randomize();
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
            if (ItemsListBox.SelectedIndex >= 0 && ItemsListBox.SelectedIndex <= _items.Count)
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
                    string addingItem = $"ID: {item.Id}; Cost: {item.Cost}; Name: {item.Name}";
                    ItemsListBox.Items.Add(addingItem);
                }

                if (selectedIndex < ItemsListBox.Items.Count)
                {
                    ItemsListBox.SelectedIndex = selectedIndex;
                }
            }
        }

        /// <summary>
        /// Проверка на ввод цифр в CostTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ',')
            {
                CostTextBox.BackColor = System.Drawing.Color.White;
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == '\r')
                {
                    _items[ItemsListBox.SelectedIndex].Cost = Convert.ToDouble(CostTextBox.Text);
                    Item item = _items[ItemsListBox.SelectedIndex];
                    ItemsListBox.Items[ItemsListBox.SelectedIndex] = $"ID: {item.Id}; Cost: {item.Cost}; Name: {item.Name}";
                }
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// При изменении текста в NameTextBox, соответствующие значения меняются в нужном item и отображаются  ItemsListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length < 200)
            {
                NameTextBox.BackColor = System.Drawing.Color.White;
                _items[ItemsListBox.SelectedIndex].Name = NameTextBox.Text;
                Item item = _items[ItemsListBox.SelectedIndex];
                ItemsListBox.Items[ItemsListBox.SelectedIndex] = $"ID: {item.Id}; Cost: {item.Cost}; Name: {item.Name}";
            }
            else
            {
                NameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Изменение описания товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DescriptionTextBox.Text.Length < 1000)
            {
                DescriptionTextBox.BackColor = System.Drawing.Color.White;
                _items[ItemsListBox.SelectedIndex].Info = DescriptionTextBox.Text;
                Item item = _items[ItemsListBox.SelectedIndex];
                ItemsListBox.Items[ItemsListBox.SelectedIndex] = $"ID: {item.Id}; Cost: {item.Cost}; Name: {item.Name}";
            }
            else
            {
                DescriptionTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Изменение категории товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _items[ItemsListBox.SelectedIndex].ItemCategory = (Category)CategoryComboBox.SelectedIndex;
        }
    }
}
