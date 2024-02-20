using System.Drawing;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();

            System.Type[] listboxContent = new System.Type[] { typeof(Color), typeof(EducationForm), typeof(Genre),
                                                     typeof(SmartphoneManufactures), typeof(Weekday) };

            ValuesListBox.Items.AddRange(Enum.GetValues(listboxContent[EnumsListBox.SelectedIndex]).Cast<object>().ToArray());
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntingValueTextbox.Text = ValuesListBox.SelectedIndex.ToString();
        }

        private void ParsingWeekdayButton_Click(object sender, EventArgs e)
        {
            string userInput = ParsingWeekdayTextbox.Text;
            if (Enum.Parse(typeof(Weekday), userInput) != null)
            {
                ParsingAnswer.Text = $"Это день недели ({userInput} = {Convert.ToInt32(Enum.Parse(typeof(Weekday), userInput))+1})";
            }
        }
    }
}