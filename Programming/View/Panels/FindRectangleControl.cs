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
    public partial class FindRectangleControl : UserControl
    {
        public FindRectangleControl()
        {
            InitializeComponent();
            RectangleInitialize(_rectangles);
        }

        // ПРЯМОУГОЛЬНИКИ
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
                double recLength = rnd.Next(1, 100);
                double recWidth = rnd.Next(1, 100);
                string recColor = Convert.ToString((Color)rnd.Next(0, 6));
                Point2D recCenter = new Point2D(recLength / 2, recWidth / 2);
                rectangles[i] = new Rectangle(recLength, recWidth, recColor, recCenter, i);
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
        // вывод значений выбранных прямоугольников при выборе их в RectangleListBox
        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedItem != null)
            {
                _currentRectangle = _rectangles[RectangleListBox.SelectedIndex];
                LengthTextBox.Text = Convert.ToString(_currentRectangle.Length);
                WidthTextBox.Text = Convert.ToString(_currentRectangle.Width);
                ColorTextBox.Text = Convert.ToString(_currentRectangle.Color);
                XTextBox.Text = Convert.ToString(_currentRectangle.Center.X);
                YTextBox.Text = Convert.ToString(_currentRectangle.Center.Y);
                IdTextBox.Text = Convert.ToString(_currentRectangle.Id);
            }
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
                if (Convert.ToDouble(LengthTextBox.Text) > 0)
                {
                    _rectangles[RectangleListBox.SelectedIndex].Length = Convert.ToDouble(LengthTextBox.Text);
                    LengthTextBox.BackColor = System.Drawing.Color.White;
                }
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
                if (Convert.ToDouble(WidthTextBox.Text) > 0)
                {
                    _rectangles[RectangleListBox.SelectedIndex].Width = Convert.ToDouble(WidthTextBox.Text);
                    WidthTextBox.BackColor = System.Drawing.Color.White;
                }
            }
            catch
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        // при изменении цвета, изменение её и в массиве
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            // проверка на то, не ввел ли пользователь вместо текста число
            bool isNumber = int.TryParse(ColorTextBox.Text, out int numericValue);
            if (isNumber == false)
            {
                _rectangles[RectangleListBox.SelectedIndex].Color = Convert.ToString(ColorTextBox.Text);
                ColorTextBox.BackColor = System.Drawing.Color.White;
            }
            else
            {
                ColorTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
    }
}
