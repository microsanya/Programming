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
        public EnumsChecking()
        {
            InitializeComponent();
        }

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
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // вывод индекса выбранного значения в ValuesListBox
            IntingValueTextbox.Text = ValuesListBox.SelectedIndex.ToString();
        }
    }
}
