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
    public partial class SeasonControl : UserControl
    {
        /// <summary>
        /// Инициализация объекта формы.
        /// </summary>
        public SeasonControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Действия при нажатии кнопки в зависимости от выбранного времени года.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonsComboBox.SelectedIndex)
            {
                case 0:
                    SeasonHandleGroupBox.BackColor = AppColors.Standart;
                    MessageBox.Show("Брр, холодно!");
                    break;
                case 1:
                    SeasonHandleGroupBox.BackColor = AppColors.SpringColor;
                    break;
                case 2:
                    SeasonHandleGroupBox.BackColor = AppColors.Standart;
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case 3:
                    SeasonHandleGroupBox.BackColor = System.Drawing.Color.Orange;
                    break;
            }
        }
    }
}
