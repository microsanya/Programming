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
    public partial class WeekdayParsingControl : UserControl
    {
        /// <summary>
        /// Инициализация объекта формы.
        /// </summary>
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Парсинг дня недели из текстового поля ParsingWeekdayTextbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParsingWeekdayButton_Click(object sender, EventArgs e)
        {
            // ввод пользовательского текста
            string userInput = ParsingWeekdayTextbox.Text;

            // булевое значение для проверки на дурака
            bool isNumber = int.TryParse(userInput, out int numericValue);
            if (Enum.TryParse(userInput, out Weekday userWeekday) && isNumber == false)
            {
                ParsingAnswer.Text = $"Это день недели ({userInput} = {Convert.ToInt32(Enum.Parse(typeof(Weekday), userInput)) + 1})";
            }
            else
            {
                ParsingAnswer.Text = "Ожидалось значение дня недели!";
            }
        }
    }
}
