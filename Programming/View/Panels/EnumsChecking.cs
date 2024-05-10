using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class EnumsChecking : UserControl
    {
        /// <summary>
        /// Инициализация элемента формы.
        /// </summary>
        public EnumsChecking()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Выполняет вывод соответствующего Enum в ValuesListBox при переключении между элементами EnumsListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // очистка списка с предыдущими значениями списков
            ValuesListBox.Items.Clear();

            // определение необходимого наполнения списка ValuesListBox
            System.Type[] listboxContent = new System.Type[] { typeof(Color), typeof(EducationForm), typeof(Genre), typeof(Season),
                                                     typeof(SmartphoneManufactures), typeof(Weekday) };

            // добавление значений в список ValuesListBox
            ValuesListBox.Items.AddRange(Enum.GetValues(listboxContent[EnumsListBox.SelectedIndex]).Cast<object>().ToArray());
        }
        /// <summary>
        /// Выполняет вывод соответствующего индекса элемента в текстовое поле IntingValueTextbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // вывод индекса выбранного значения в ValuesListBox
            IntingValueTextbox.Text = ValuesListBox.SelectedIndex.ToString();
        }
    }
}
