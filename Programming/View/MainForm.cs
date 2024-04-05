using System.Drawing;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        // ����������� �������������� ���������� � ������ ---------------------------------------

        // ��������������
        // �������� ����, �������� ������ ���������������
        private Rectangle[] _rectangles = new Rectangle[5];
        // ����� �� ����, �� ���� List ��� ������� Rectangles
        private List<Rectangle> _newRectangles = new List<Rectangle>();
        // ����� ��������� �������������
        private Rectangle _currentRectangle = new Rectangle();
        // ���� ������� ���������������
        //������������� ������� ���������������
        private void RectangleInitialize(Rectangle[] rectangles)
        {
            //�������� ������� ��� ��������� �����
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
        // ����� �������������� � ���������� �������
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

        // ������
        // �������� ����, �������� ������ �������
        private Film[] _films = new Film[5];
        // ����� ��������� �����
        private Film _currentFilm = new Film();
        //������������� ������� �������
        private void FilmInitialize(Film[] films)
        {
            //�������� ������� ��� ��������� �����
            Random rnd = new Random();
            for (int i = 0; i < 5; ++i)
            {
                films[i] = new Film(Convert.ToString((FilmNames)rnd.Next(0, 7)), rnd.Next(1, 300), rnd.Next(1900, 2024),
                    Convert.ToString((Genre)rnd.Next(0, 5)), rnd.Next(1, 10));
            }
        }
        // ����� ������ � ���������� ���������
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

        // �������� ������ ����� ---------------------------------------------------------------
        public MainForm()
        {
            InitializeComponent();
            RectangleInitialize(_rectangles);
            FilmInitialize(_films);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // ������ � Enums ----------------------------------------------------------------------
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ������� ������ � ����������� ���������� �������
            ValuesListBox.Items.Clear();

            // ����������� ������������ ���������� ������ ValuesListBox
            System.Type[] listboxContent = new System.Type[] { typeof(Color), typeof(EducationForm), typeof(Genre),
                                                     typeof(SmartphoneManufactures), typeof(Weekday) };

            // ���������� �������� � ������ ValuesListBox
            ValuesListBox.Items.AddRange(Enum.GetValues(listboxContent[EnumsListBox.SelectedIndex]).Cast<object>().ToArray());
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ����� ������� ���������� �������� � ValuesListBox
            IntingValueTextbox.Text = ValuesListBox.SelectedIndex.ToString();
        }

        private void ParsingWeekdayButton_Click(object sender, EventArgs e)
        {
            // ���� ����������������� ������
            string userInput = ParsingWeekdayTextbox.Text;

            // ������� �������� ��� �������� �� ������
            bool isNumber = int.TryParse(userInput, out int numericValue);
            if (Enum.TryParse(userInput, out Weekday userWeekday) && isNumber == false)
            {
                ParsingAnswer.Text = $"��� ���� ������ ({userInput} = {Convert.ToInt32(Enum.Parse(typeof(Weekday), userInput)) + 1})";
            }
            else
            {
                ParsingAnswer.Text = "��������� �������� ��� ������!";
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            // �������� ��� ������� ������ � ����������� �� ���������� ������� ����
            switch (SeasonsComboBox.SelectedIndex)
            {
                case 0:
                    SeasonHandleGroupBox.BackColor = System.Drawing.Color.White;
                    MessageBox.Show("���, �������!");
                    break;
                case 1:
                    SeasonHandleGroupBox.BackColor = System.Drawing.Color.Green;
                    break;
                case 2:
                    SeasonHandleGroupBox.BackColor = System.Drawing.Color.White;
                    MessageBox.Show("���! ������!");
                    break;
                case 3:
                    SeasonHandleGroupBox.BackColor = System.Drawing.Color.Orange;
                    break;
            }
        }
        // ������ � ���������������� ----------------------------------------------------------------------
        // ����� �������� ��������� ��������������� ��� ������ �� � RectangleListBox
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

        // �������� ������� �������������� � ������������ �������
        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int indexMaxRectangle = FindRectangleWithMaxWidth(_rectangles);
            RectangleListBox.SelectedIndex = indexMaxRectangle;
        }
        // ��� ��������� �����, ��������� � � � �������
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
        // ��� ��������� ������, ��������� � � � �������
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
        // ��� ��������� �����, ��������� � � � �������
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            // �������� �� ��, �� ���� �� ������������ ������ ������ �����
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

        // ������ � �������� ------------------------------------------------------------------------
        // ����� �������� ��������� ������� ��� ������ �� � FilmsListBox
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
        // ��� ��������� �����, ��������� ��� � � �������
        private void FilmNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // �������� �� ��, �� ���� �� ������������ ������ ������ �����
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
        // ��� ��������� ������������, ��������� � � � �������
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
        // ��� ��������� ����, ��������� ��� � � �������
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
        // ��� ��������� �����, ��������� ��� � � �������
        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            // �������� �� ��, �� ���� �� ������������ ������ ������ �����
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
        // ��� ��������� ��������, ��������� ��� � � �������
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
        // ������� ������ ������ ������ � ���������� ���������
        private void FilmFindButton_Click(object sender, EventArgs e)
        {
            int indexMaxFilm = FindFilmWithMaxRating(_films);
            FilmsListBox.SelectedIndex = indexMaxFilm;
        }

        // ������ � �������� Rectangles ---------------------------------------------------------------
        // ������ "�������� �������������"
        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            double recLength = rnd.Next(1, 100);
            double recWidth = rnd.Next(1, 100);
            string recColor = Convert.ToString((Color)rnd.Next(0, 6));
            Point2D recCenter = new Point2D(recLength / 2, recWidth / 2);

            Rectangle newRectangle = new Rectangle(recLength, recWidth, recColor, recCenter, 0);

            _newRectangles.Add(newRectangle);

            string addingString = $"{newRectangle.Id - 5}: (X= {newRectangle.Center.X}; Y= {newRectangle.Center.Y}; " +
                $"W= {newRectangle.Width}; H= {newRectangle.Length})";
            RectanglesViewlistBox.Items.Add(addingString);
        }
        // ����� ��������
        private void RectanglesViewlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesViewlistBox.SelectedItem != null)
            {
                int selectedRectNumber = RectanglesViewlistBox.SelectedIndex;
                _currentRectangle = _newRectangles[selectedRectNumber];
                // ID
                IDTextBoxNew.Text = Convert.ToString(selectedRectNumber + 1);
                // X
                XTextBoxNew.Text = Convert.ToString(_currentRectangle.Center.X);
                // Y
                YTextBoxNew.Text = Convert.ToString(_currentRectangle.Center.Y);
                // Width
                WidthTextBoxNew.Text = Convert.ToString(_currentRectangle.Width);
                // Height
                HeightTextBoxNew.Text = Convert.ToString(_currentRectangle.Length);
            }
        }
        // ������ "������� �������������"
        private void DeleteRectangleButton_Click(object sender, EventArgs e)
        {
            if (RectanglesViewlistBox.SelectedItem != null)
            {
                _newRectangles.RemoveAt(RectanglesViewlistBox.SelectedIndex);
                RectanglesViewlistBox.Items.RemoveAt(RectanglesViewlistBox.SelectedIndex);
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
        }
        // �������������� �����
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
                }
            }
            catch
            {
                HeightTextBoxNew.BackColor = System.Drawing.Color.LightPink;
            }
        }
    }
}