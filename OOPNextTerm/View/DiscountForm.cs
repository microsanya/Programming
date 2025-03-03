using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPNextTerm.View
{
    public partial class DiscountForm : Form
    {
        /// <summary>
        /// Получает или задает процентную скидку, которая будет добавлена.
        /// </summary>
        public PercentDiscount PercentDiscount { get; set; }

        public DiscountForm()
        {
            InitializeComponent();
            DCategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки ОК.
        /// Проверяет, выбрана ли категория, и закрывает форму, возвращая результат ОК.
        /// </summary>
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (DCategoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("Вы не выбрали категорию!");
                return;
            }
            PercentDiscount = new PercentDiscount((Category)DCategoryComboBox.SelectedItem, 0);
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки Отмена.
        /// Закрывает форму с результатом Cancel.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
