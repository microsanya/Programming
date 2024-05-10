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
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Инициализация объекта формы.
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Лист прямоугольников.
        /// </summary>
        private List<Rectangle> _newRectangles = new List<Rectangle>();
        /// <summary>
        /// Ранее созданный прямоугольник
        /// </summary>
        private Rectangle _currentRectangle = new Rectangle();
        /// <summary>
        /// Лист панелек прямоугольников.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Работа с пересечением прямоугольников.
        /// </summary>
        private void FindCollision()
        {
            foreach (var panel in _rectanglePanels)
            {
                panel.BackColor = AppColors.NormalRectangle;
            }

            for (int i = 0; i < _newRectangles.Count; i++)
            {
                for (int j = 0; j < _newRectangles.Count; j++)
                {
                    if (!(_newRectangles[i] == _newRectangles[j]) && CollisionManager.IsCollision(_newRectangles[i], _newRectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = AppColors.CollRectangle;

                        _rectanglePanels[j].BackColor = AppColors.CollRectangle;
                    }

                }
            }
        }

        /// <summary>
        /// Обновление данных в текстовых полях по указанному прямоугольнику.
        /// </summary>
        /// <param name="rectangle"></param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            // ID
            IDTextBoxNew.Text = Convert.ToString(rectangle.Id - 1);
            // X
            XTextBoxNew.Text = Convert.ToString(rectangle.Center.X);
            // Y
            YTextBoxNew.Text = Convert.ToString(rectangle.Center.Y);
            // Width
            WidthTextBoxNew.Text = Convert.ToString(rectangle.Width);
            // Height
            HeightTextBoxNew.Text = Convert.ToString(rectangle.Length);
        }

        /// <summary>
        /// Очистка данных в текстовых полях.
        /// </summary>
        private void ClearRectangleInfo()
        {
            // ID
            IDTextBoxNew.Text = "";
            // X
            XTextBoxNew.Text = "";
            // Y
            YTextBoxNew.Text = "";
            // Width
            WidthTextBoxNew.Text = "";
            // Height
            HeightTextBoxNew.Text = "";
        }

        /// <summary>
        /// Добавление прямоугольника с помощью кнопки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            Rectangle newRectangle = RectangleFactory.Randomize();
            _newRectangles.Add(newRectangle);

            string addingString = $"{newRectangle.Id - 5}: (X= {newRectangle.Center.X}; Y= {newRectangle.Center.Y}; " +
                $"W= {newRectangle.Width}; H= {newRectangle.Length})";
            // добавление в RectangleViewlistBox
            RectanglesViewlistBox.Items.Add(addingString);
            // добавление на CanvaPanel
            Panel newPanel = new Panel();
            newPanel.Top = Convert.ToInt32(newRectangle.Center.Y);
            newPanel.Left = Convert.ToInt32(newRectangle.Center.X);
            newPanel.Height = Convert.ToInt32(newRectangle.Length);
            newPanel.Width = Convert.ToInt32(newRectangle.Width);
            newPanel.BackColor = AppColors.NormalRectangle;
            CanvaPanel.Controls.Add(newPanel);
            // добавление в List<Panel>
            _rectanglePanels.Add(newPanel);
            // проверка на пересечение
            FindCollision();
        }

        /// <summary>
        /// Выбор прямоугольника в RectanglesViewlistBox.
        /// </summaЫry>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesViewlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesViewlistBox.SelectedItem != null)
            {
                int selectedRectNumber = RectanglesViewlistBox.SelectedIndex;
                _currentRectangle = _newRectangles[selectedRectNumber];
                UpdateRectangleInfo(_currentRectangle);
            }
        }

        /// <summary>
        /// Удаление прямоугольника с помощью кнопки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteRectangleButton_Click(object sender, EventArgs e)
        {
            if (RectanglesViewlistBox.SelectedItem != null)
            {
                // удаление с Canva
                _rectanglePanels.RemoveAt(RectanglesViewlistBox.SelectedIndex);
                CanvaPanel.Controls.RemoveAt(RectanglesViewlistBox.SelectedIndex);
                //удаление с RectanglesViewlistBox
                _newRectangles.RemoveAt(RectanglesViewlistBox.SelectedIndex);
                RectanglesViewlistBox.Items.RemoveAt(RectanglesViewlistBox.SelectedIndex);
                // Очистка textbox'ов
                ClearRectangleInfo();
                // проверка на пересечение
                FindCollision();
            }
        }

        /// <summary>
        /// Изменение поля WidthTextBoxNew.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthTextBoxNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(WidthTextBoxNew.Text) > 0)
                {
                    _newRectangles[RectanglesViewlistBox.SelectedIndex].Width = Convert.ToDouble(WidthTextBoxNew.Text);
                    Rectangle rect = _newRectangles[RectanglesViewlistBox.SelectedIndex];
                    WidthTextBoxNew.BackColor = AppColors.Standart;
                    RectanglesViewlistBox.Items[RectanglesViewlistBox.SelectedIndex] = $"{rect.Id - 5}: (X= {rect.Center.X}; " +
                        $"Y= {rect.Center.Y}; W= {rect.Width}; H= {rect.Length})";
                    _rectanglePanels[RectanglesViewlistBox.SelectedIndex].Width = (int)rect.Width;
                    FindCollision();
                }
            }
            catch
            {
                WidthTextBoxNew.BackColor = AppColors.Error;
            }
        }

        /// <summary>
        /// Изменение поля HeightTextBoxNew.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBoxNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(HeightTextBoxNew.Text) > 0)
                {
                    _newRectangles[RectanglesViewlistBox.SelectedIndex].Length = Convert.ToDouble(HeightTextBoxNew.Text);
                    Rectangle rect = _newRectangles[RectanglesViewlistBox.SelectedIndex];
                    HeightTextBoxNew.BackColor = AppColors.Standart;
                    RectanglesViewlistBox.Items[RectanglesViewlistBox.SelectedIndex] = $"{rect.Id - 5}: (X= {rect.Center.X}; " +
                       $"Y= {rect.Center.Y}; W= {rect.Width}; H= {rect.Length})";
                    _rectanglePanels[RectanglesViewlistBox.SelectedIndex].Height = (int)rect.Length;
                    FindCollision();
                }
            }
            catch
            {
                HeightTextBoxNew.BackColor = AppColors.Error;
            }
        }
    }
}
