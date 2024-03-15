using System.Drawing;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        // �������� ����, �������� ������ ���������������
        private Rectangle[] _rectangles = new Rectangle[5];
        // ����� ��������� �������������
        private Rectangle _currentRectangle = new Rectangle();
        //������������� ������� ���������������
        private void RectangleInitialize(Rectangle[] rectangles)
        {
            //�������� ������� ��� ��������� �����
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

        // ����� �������� ��������� ��������������� ��� ������ �� � RectangleListBox
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
                _rectangles[RectangleListBox.SelectedIndex].Length = Convert.ToDouble(LengthTextBox.Text);
                LengthTextBox.BackColor = System.Drawing.Color.White;
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
                _rectangles[RectangleListBox.SelectedIndex].Width = Convert.ToDouble(WidthTextBox.Text);
                WidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        // ��� ��������� �����, ��������� � � � �������
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _rectangles[RectangleListBox.SelectedIndex].Color = Convert.ToString(ColorTextBox.Text);
        }
    }
}