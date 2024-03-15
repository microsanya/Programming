using System.Drawing;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        // закрытое поле, хранящее массив прямоугольников
        private Rectangle[] _rectangles = new Rectangle[5];
        // ранее созданный прямоугольник
        private Rectangle _currentRectangle = new Rectangle();
        //инициализация массива прямоугольников
        private void RectangleInitialize(Rectangle[] rectangles)
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random();
            for (int i = 0; i < 5; ++i)
            {
                rectangles[i] = new Rectangle(rnd.Next(1, 100), rnd.Next(1, 100), Convert.ToString((Color)rnd.Next(0, 6)));
            }
        }

        public MainForm()
        {
            InitializeComponent();
            RectangleInitialize(_rectangles);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // очистка списка с предыдущими значениями списков
            ValuesListBox.Items.Clear();

            // определение необходимого наполнения списка ValuesListBox
            System.Type[] listboxContent = new System.Type[] { typeof(Color), typeof(EducationForm), typeof(Genre),
                                                     typeof(SmartphoneManufactures), typeof(Weekday) };

            // добавление значений в список ValuesListBox
            ValuesListBox.Items.AddRange(Enum.GetValues(listboxContent[EnumsListBox.SelectedIndex]).Cast<object>().ToArray());
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // вывод индекса выбранного значения в ValuesListBox
            IntingValueTextbox.Text = ValuesListBox.SelectedIndex.ToString();
        }

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

        private void GoButton_Click(object sender, EventArgs e)
        {
            // действия при нажатии кнопки в зависимости от выбранного времени года
            switch (SeasonsComboBox.SelectedIndex)
            {
                case 0:
                    SeasonHandleGroupBox.BackColor = System.Drawing.Color.White;
                    MessageBox.Show("Брр, холодно!");
                    break;
                case 1:
                    SeasonHandleGroupBox.BackColor = System.Drawing.Color.Green;
                    break;
                case 2:
                    SeasonHandleGroupBox.BackColor = System.Drawing.Color.White;
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case 3:
                    SeasonHandleGroupBox.BackColor = System.Drawing.Color.Orange;
                    break;
            }
        }

        // вывод значений выбранных прямоугольников при выборе их в RectangleListBox
        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedItem != null)
            {
                _currentRectangle = _rectangles[RectangleListBox.SelectedIndex];
                LengthTextBox.Text = Convert.ToString(_currentRectangle.Length);
                WidthTextBox.Text = Convert.ToString(_currentRectangle.Width);
                ColorTextBox.Text = Convert.ToString(_currentRectangle.Color);
            }
        }
        // поиск прямоугольника с наибольшей шириной
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            double maxWidth = 0;
            int indexMaxRectangle = 0;
            for (int i = 0; i < rectangles.Length; ++i)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    indexMaxRectangle = i;
                }
            }
            return indexMaxRectangle;
        }
        // передача индекса прямоугольника с максимальной шириной
        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int indexMaxRectangle = FindRectangleWithMaxWidth(_rectangles);
            RectangleListBox.SelectedIndex = indexMaxRectangle;

        }
        // при изменении длины, изменение её и в массиве
        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangles[RectangleListBox.SelectedIndex].Length = Convert.ToDouble(LengthTextBox.Text);
                LengthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        // при изменении ширины, изменение её и в массиве
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _rectangles[RectangleListBox.SelectedIndex].Width = Convert.ToDouble(WidthTextBox.Text);
                WidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        // при изменении цвета, изменение её и в массиве
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _rectangles[RectangleListBox.SelectedIndex].Color = Convert.ToString(ColorTextBox.Text);
        }
    }
}