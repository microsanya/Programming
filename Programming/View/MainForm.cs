using System.Drawing;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        // необходимые дополнительные переменные и методы ---------------------------------------

        // ПРЯМОУГОЛЬНИКИ
        // закрытое поле, хранящее массив прямоугольников
        private Rectangle[] _rectangles = new Rectangle[5];
        // такое же поле, но типа List для вкладки Rectangles
        private List<Rectangle> _newRectangles = new List<Rectangle>();
        // ранее созданный прямоугольник
        private Rectangle _currentRectangle = new Rectangle();
        // лист панелек прямоугольников
        private List<Panel> _rectanglePanels = new List<Panel>();
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
        // пересечение прямоугольников
        private void FindCollision()
        {
            foreach (var panel in _rectanglePanels)
            {
                panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            }

            for (int i = 0; i < _newRectangles.Count; i++)
            {
                for (int j = 0; j < _newRectangles.Count; j++)
                {
                    if (!(_newRectangles[i] == _newRectangles[j]) && CollisionManager.IsCollision(_newRectangles[i], _newRectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);

                        _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                    }

                }
            }
        }
        // Обновление данных в текстовых полях по указанному прямоугольнику
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
        // очистка данных в текстовых полях
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

        // ФИЛЬМЫ
        // закрытое поле, хранящее массив фильмов
        private Film[] _films = new Film[5];
        // ранее созданный фильм
        private Film _currentFilm = new Film();
        //инициализация массива фильмов
        private void FilmInitialize(Film[] films)
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random();
            for (int i = 0; i < 5; ++i)
            {
                films[i] = new Film(Convert.ToString((FilmNames)rnd.Next(0, 7)), rnd.Next(1, 300), rnd.Next(1900, 2024),
                    Convert.ToString((Genre)rnd.Next(0, 5)), rnd.Next(1, 10));
            }
        }
        // поиск фильма с наибольшим рейтингом
        private int FindFilmWithMaxRating(Film[] films)
        {
            int maxRating = 0;
            int indexMaxFilm = 0;
            for (int i = 0; i < films.Length; ++i)
            {
                if (films[i].Rating > maxRating)
                {
                    maxRating = films[i].Rating;
                    indexMaxFilm = i;
                }
            }
            return indexMaxFilm;
        }

        // основная логика формы ---------------------------------------------------------------
        public MainForm()
        {
            InitializeComponent();
            RectangleInitialize(_rectangles);
            FilmInitialize(_films);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // работа с Enums ----------------------------------------------------------------------
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
        // работа с прямоугольниками ----------------------------------------------------------------------
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

        // работа с фильмами ------------------------------------------------------------------------
        // вывод значений выбранных фильмов при выборе их в FilmsListBox
        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilmsListBox.SelectedItem != null)
            {
                _currentFilm = _films[FilmsListBox.SelectedIndex];
                FilmNameTextBox.Text = Convert.ToString(_currentFilm.Name);
                DurationTextBox.Text = Convert.ToString(_currentFilm.Duration);
                YearTextBox.Text = Convert.ToString(_currentFilm.Year);
                GenreTextBox.Text = Convert.ToString(_currentFilm.Genre);
                RatingTextBox.Text = Convert.ToString(_currentFilm.Rating);
            }
        }
        // при изменении имени, изменение его и в массиве
        private void FilmNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // проверка на то, не ввел ли пользователь вместо текста число
            bool isNumber = int.TryParse(FilmNameTextBox.Text, out int numericValue);
            if (isNumber == false)
            {
                _films[FilmsListBox.SelectedIndex].Name = Convert.ToString(FilmNameTextBox.Text);
                FilmNameTextBox.BackColor = System.Drawing.Color.White;
            }
            else
            {
                FilmNameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        // при изменении длительности, изменение её и в массиве
        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(DurationTextBox.Text) > 0)
                {
                    _films[FilmsListBox.SelectedIndex].Duration = Convert.ToInt32(DurationTextBox.Text);
                    DurationTextBox.BackColor = System.Drawing.Color.White;
                }
            }
            catch
            {
                DurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        // при изменении года, изменение его и в массиве
        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(YearTextBox.Text) >= 1900 && Convert.ToInt32(YearTextBox.Text) <= 2024)
                {
                    _films[FilmsListBox.SelectedIndex].Year = Convert.ToInt32(YearTextBox.Text);
                    YearTextBox.BackColor = System.Drawing.Color.White;
                }
            }
            catch
            {
                YearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        // при изменении жанра, изменение его и в массиве
        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            // проверка на то, не ввел ли пользователь вместо текста число
            bool isNumber = int.TryParse(GenreTextBox.Text, out int numericValue);
            if (isNumber == false)
            {
                _films[FilmsListBox.SelectedIndex].Genre = Convert.ToString(GenreTextBox.Text);
                GenreTextBox.BackColor = System.Drawing.Color.White;
            }
            else
            {
                GenreTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        // при изменении рейтинга, изменение его и в массиве
        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(RatingTextBox.Text) >= 0 && Convert.ToInt32(RatingTextBox.Text) <= 10)
                {
                    _films[FilmsListBox.SelectedIndex].Rating = Convert.ToInt32(RatingTextBox.Text);
                    RatingTextBox.BackColor = System.Drawing.Color.White;
                }
            }
            catch
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        // функция кнопки поиска фильма с наибольшим рейтингом
        private void FilmFindButton_Click(object sender, EventArgs e)
        {
            int indexMaxFilm = FindFilmWithMaxRating(_films);
            FilmsListBox.SelectedIndex = indexMaxFilm;
        }

        // работа с вкладкой Rectangles ---------------------------------------------------------------
        // кнопка "добавить прямоугольник"
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
            newPanel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            CanvaPanel.Controls.Add(newPanel);
            // добавление в List<Panel>
            _rectanglePanels.Add(newPanel);
            // проверка на пересечение
            FindCollision();
        }
        // выбор элемента
        private void RectanglesViewlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesViewlistBox.SelectedItem != null)
            {
                int selectedRectNumber = RectanglesViewlistBox.SelectedIndex;
                _currentRectangle = _newRectangles[selectedRectNumber];
                UpdateRectangleInfo(_currentRectangle);
            }
        }
        // кнопка "удалить прямоугольник"
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
        // редактирование полей
        // Width
        private void WidthTextBoxNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(WidthTextBoxNew.Text) > 0)
                {
                    _newRectangles[RectanglesViewlistBox.SelectedIndex].Width = Convert.ToDouble(WidthTextBoxNew.Text);
                    Rectangle rect = _newRectangles[RectanglesViewlistBox.SelectedIndex];
                    WidthTextBoxNew.BackColor = System.Drawing.Color.White;
                    RectanglesViewlistBox.Items[RectanglesViewlistBox.SelectedIndex] = $"{rect.Id - 5}: (X= {rect.Center.X}; " +
                        $"Y= {rect.Center.Y}; W= {rect.Width}; H= {rect.Length})";
                    _rectanglePanels[RectanglesViewlistBox.SelectedIndex].Width = (int)rect.Width;
                    FindCollision();
                }
            }
            catch
            {
                WidthTextBoxNew.BackColor = System.Drawing.Color.LightPink;
            }
        }
        // Height
        private void HeightTextBoxNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(HeightTextBoxNew.Text) > 0)
                {
                    _newRectangles[RectanglesViewlistBox.SelectedIndex].Length = Convert.ToDouble(HeightTextBoxNew.Text);
                    Rectangle rect = _newRectangles[RectanglesViewlistBox.SelectedIndex];
                    HeightTextBoxNew.BackColor = System.Drawing.Color.White;
                    RectanglesViewlistBox.Items[RectanglesViewlistBox.SelectedIndex] = $"{rect.Id - 5}: (X= {rect.Center.X}; " +
                       $"Y= {rect.Center.Y}; W= {rect.Width}; H= {rect.Length})";
                    _rectanglePanels[RectanglesViewlistBox.SelectedIndex].Height = (int)rect.Length;
                    FindCollision();
                }
            }
            catch
            {
                HeightTextBoxNew.BackColor = System.Drawing.Color.LightPink;
            }
        }
        //// изменения стиля кнопок
        //// наведение мыши
        //private void AddRectangleButton_MouseEnter(object sender, EventArgs e)
        //{
        //    AddRectangleButton.Image = Properties.Resources.add_rectangle_2;
        //    //AddRectangleButton.FlatAppearance.BorderSize = 0;
        //}
        //// убрали мышь
        //private void AddRectangleButton_MouseLeave(object sender, EventArgs e)
        //{
        //    AddRectangleButton.Image = Properties.Resources.add_rectangle;
        //}
    }
}