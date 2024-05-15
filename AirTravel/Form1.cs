using AirTravel.Properties;
using System.Windows.Forms;

namespace AirTravel
{
    public partial class AirTravelForm : Form
    {
        /// <summary>
        /// Инициализация формы.
        /// </summary>
        public AirTravelForm()
        {
            InitializeComponent();
        }
        // -------------------------------------- Необходимые доп. переменные и контейнеры ----------------------------------------------------
        /// <summary>
        /// Лист полётов.
        /// </summary>
        private List<Flight> _newFlights = new List<Flight>();

        /// <summary>
        /// Ранее созданный полёт.
        /// </summary>
        private Flight _currentFlight = new Flight();

        //------------------------------------------------------ Методы ------------------------------------------------------------------------

        /// <summary>
        /// Сортировка перелётов по времени вылета.
        /// </summary>
        /// <param name="flights">Лист полётов.</param>
        private void FlightsViewListBoxSort (List<Flight> flights)
        {
            int n = flights.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (flights[j].DepartureTime > flights[j + 1].DepartureTime)
                    {
                        Flight flight = flights[j];
                        string strFlight = FlightsViewListBox.Items[j].ToString();

                        flights[j] = flights[j + 1];
                        FlightsViewListBox.Items[j] = FlightsViewListBox.Items[j + 1].ToString();

                        flights[j + 1] = flight;
                        FlightsViewListBox.Items[j + 1] = strFlight;
                    }
                }
            }
        }


        /// <summary>
        /// Обновление данных в текстовых полях по указанному полёту.
        /// </summary>
        /// <param name="flight"></param>
        private void UpdateFlightInfo(Flight flight)
        {
            // Departure Point
            DPTextBox.Text = Convert.ToString(flight.DeparturePoint);
            // Destination
            DestinationTextBox.Text = Convert.ToString(flight.Destination);
            // Departure Time
            DTDataTimePicker.Value = flight.DepartureTime;
            // FLight Time
            FlightTimeTextBox.Text = Convert.ToString(flight.TimeFlight);
            // Flight Type
            FTypeComboBox.SelectedIndex = FTypeComboBox.FindString(flight.FlightType.ToString());
            // Airline
            AirlinePictureBox.Image = flight.Airline;
        }

        /// <summary>
        /// Очистка данных в полях по полёту.
        /// </summary>
        private void ClearFlightInfo()
        {
            // Departure Point
            DPTextBox.Text = "";
            // Destination
            DestinationTextBox.Text = "";
            // Departure Time
            DTDataTimePicker.Value = DateTime.Now;
            // FLight Time
            FlightTimeTextBox.Text = "";
            // Flight Type
            FTypeComboBox.SelectedIndex = 2;
            // Airline
            AirlinePictureBox.Image = Resources.plane;
        }

        /// <summary>
        /// Выбор полёта в FlightsViewListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlightsViewListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FlightsViewListBox.SelectedItem != null)
            {
                int index = FlightsViewListBox.SelectedIndex;
                _currentFlight = _newFlights[index];
                UpdateFlightInfo(_currentFlight);
            }

            // Сортировка
            FlightsViewListBoxSort(_newFlights);
        }

        /// <summary>
        /// Добавление полёта в FlightsViewListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonPB_Click(object sender, EventArgs e)
        {
            Flight newFlight = new Flight();
            _newFlights.Add(newFlight);
            string addingFlight = $"Время вылета: {newFlight.DeparturePoint} - {newFlight.Destination}";
            FlightsViewListBox.Items.Add(addingFlight);

            // Сортировка
            FlightsViewListBoxSort(_newFlights);
        }

        /// <summary>
        /// Наведение мыши на кнопку добавления (анимация).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonPB_MouseEnter(object sender, EventArgs e)
        {
            AddButtonPB.BackColor = Color.LightGray;
        }

        /// <summary>
        /// Мышь не на кнопке добавления (анимация).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonPB_MouseLeave(object sender, EventArgs e)
        {
            AddButtonPB.BackColor = AirTravelForm.DefaultBackColor;
        }

        /// <summary>
        /// Клик мыши на кнопку (анимация).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonPB_MouseClick(object sender, MouseEventArgs e)
        {
            AddButtonPB.BackColor = Color.Gray;
        }

        /// <summary>
        /// Удаление полёта из FlightsViewListBox и листа полётов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButtonPB_Click(object sender, EventArgs e)
        {
            if (FlightsViewListBox.SelectedItem != null)
            {
                _newFlights.RemoveAt(FlightsViewListBox.SelectedIndex);
                FlightsViewListBox.Items.RemoveAt(FlightsViewListBox.SelectedIndex);
                ClearFlightInfo();

                // Сортировка
                FlightsViewListBoxSort(_newFlights);
            }
        }

        /// <summary>
        /// Наведение мыши на кнопку удаления (анимация).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButtonPB_MouseEnter(object sender, EventArgs e)
        {
            DeleteButtonPB.BackColor = Color.LightGray;
        }

        /// <summary>
        /// Мышь не на кнопке удаления (анимация).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButtonPB_MouseLeave(object sender, EventArgs e)
        {
            DeleteButtonPB.BackColor = AirTravelForm.DefaultBackColor;
        }

        /// <summary>
        /// Клик на кнопку удаления (анимация).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButtonPB_MouseClick(object sender, MouseEventArgs e)
        {
            DeleteButtonPB.BackColor = Color.Gray;
        }

        /// <summary>
        /// Изменение значения места отправления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DPTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (DPTextBox.Text.Length <= 100)
                {
                    _newFlights[FlightsViewListBox.SelectedIndex].DeparturePoint = DPTextBox.Text;
                    Flight flight = _newFlights[FlightsViewListBox.SelectedIndex];
                    DPTextBox.BackColor = System.Drawing.Color.White;
                    FlightsViewListBox.Items[FlightsViewListBox.SelectedIndex] = $"Время вылета: {flight.DeparturePoint} - {flight.Destination}";
                }
                else
                {
                    DPTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch
            {
                DPTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Изменение значения места назначения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DestinationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (DestinationTextBox.Text.Length <= 100)
                {
                    _newFlights[FlightsViewListBox.SelectedIndex].Destination = DestinationTextBox.Text;
                    Flight flight = _newFlights[FlightsViewListBox.SelectedIndex];
                    DestinationTextBox.BackColor = System.Drawing.Color.White;
                    FlightsViewListBox.Items[FlightsViewListBox.SelectedIndex] = $"Время вылета: {flight.DeparturePoint} - {flight.Destination}";
                }
                else
                {
                    DestinationTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch
            {
                DestinationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Изменение даты вылета.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DTDataTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DTDataTimePicker.Value >= DateTime.Now)
                {
                    _newFlights[FlightsViewListBox.SelectedIndex].DepartureTime = DTDataTimePicker.Value;
                }
                else
                {
                    MessageBox.Show("Дата не может быть раньше сегодняшней!");
                }
            }
            catch
            {
                MessageBox.Show("Дата не может быть раньше сегодняшней!");
            }
        }

        /// <summary>
        /// Изменение времени полёта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlightTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(FlightTimeTextBox.Text) >= 0 && Convert.ToInt32(FlightTimeTextBox.Text) <= 1000)
                {
                    _newFlights[FlightsViewListBox.SelectedIndex].TimeFlight = Convert.ToInt32(FlightTimeTextBox.Text);
                    FlightTimeTextBox.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    FlightTimeTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch
            {
                FlightTimeTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Изменение типа рейса.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _newFlights[FlightsViewListBox.SelectedIndex].FlightType = (FlightType)Enum.GetValues(typeof(FlightType)).GetValue
                (FTypeComboBox.SelectedIndex);
            FTypeComboBox.SelectedIndex = (int)_newFlights[FlightsViewListBox.SelectedIndex].FlightType;
        }

        /// <summary>
        /// Изменение иконки авиакомпании.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AirlinePictureBox_Click(object sender, EventArgs e)
        {
            // Открыть диалоговое окно выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы изображений|*.png;*.jpg;*.jpeg;*.gif;*.bmp|Все файлы|*.*";
            openFileDialog.Title = "Выберите изображение";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Загрузить выбранный файл в PictureBox
                AirlinePictureBox.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
                _newFlights[FlightsViewListBox.SelectedIndex].Airline = new System.Drawing.Bitmap(openFileDialog.FileName);
            }
        }
    }
}