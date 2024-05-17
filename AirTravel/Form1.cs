using AirTravel.Properties;
using System.Windows.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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
            this.Load += new System.EventHandler(this.AirTravelForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AirTravelForm_FormClosing);
        }

        /// <summary>
        /// Загрузка формы + информации с файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AirTravelForm_Load(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AirTravel");
            Directory.CreateDirectory(folderPath);
            string filePath = Path.Combine(folderPath, "flights_data.json");


            LoadDataFromFile(filePath);
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
        /// Сохранение информации в файл.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        private void SaveDataToFile(string filePath)
        {
            var flightDataList = _newFlights.Select(flight => new FlightData
            {
                DeparturePoint = flight.DeparturePoint,
                Destination = flight.Destination,
                DepartureTime = flight.DepartureTime,
                TimeFlight = flight.TimeFlight,
                FlightType = flight.FlightType,
                AirlineBase64 = flight.Airline != null ? Convert.ToBase64String((byte[])(new ImageConverter()).ConvertTo(flight.Airline, typeof(byte[]))) : null
            }).ToList();

            string jsonData = JsonConvert.SerializeObject(flightDataList, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }

        /// <summary>
        /// Загрузка информации из файла.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        private void LoadDataFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                return;

            string jsonData = File.ReadAllText(filePath);
            var flightDataList = JsonConvert.DeserializeObject<List<FlightData>>(jsonData);

            _newFlights.Clear();
            FlightsViewListBox.Items.Clear();

            foreach (var flightData in flightDataList)
            {
                Flight flight = new Flight
                {
                    DeparturePoint = flightData.DeparturePoint,
                    Destination = flightData.Destination,
                    DepartureTime = flightData.DepartureTime,
                    TimeFlight = flightData.TimeFlight,
                    FlightType = flightData.FlightType,
                    Airline = !string.IsNullOrEmpty(flightData.AirlineBase64) ? new Bitmap(new MemoryStream(Convert.FromBase64String(flightData.AirlineBase64))) : null
                };

                _newFlights.Add(flight);
                FlightsViewListBox.Items.Add($"{flight.DepartureTime.ToString()}: {flight.DeparturePoint} - {flight.Destination}");
            }
        }

        /// <summary>
        /// Метод, сохраняющий данные в файл при закрытии формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AirTravelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AirTravel");
            Directory.CreateDirectory(folderPath);
            string filePath = Path.Combine(folderPath, "flights_data.json");
            SaveDataToFile(filePath);
        }

        /// <summary>
        /// Сортировка перелётов по времени вылета.
        /// </summary>
        /// <param name="flights">Лист полётов.</param>
        private void FlightsViewListBoxSort(List<Flight> flights)
        {
            flights.Sort((flight1, flight2) => flight1.DepartureTime.CompareTo(flight2.DepartureTime));

            FlightsViewListBox.Items.Clear();

            foreach (var flight in flights)
            {
                string displayFlight = $"{flight.DepartureTime.ToString()} : {flight.DeparturePoint} - {flight.Destination}";
                FlightsViewListBox.Items.Add(displayFlight);
            }
        }

        /// <summary>
        /// Показ всех полётов после поиска.
        /// </summary>
        private void DisplayAllFlights()
        {
            // Очистка предыдущих результатов поиска
            FlightsViewListBox.Items.Clear();

            // Отображение всех доступных полётов
            foreach (var flight in _newFlights)
            {
                string displayFlight = $"{flight.DepartureTime.ToString()} : {flight.DeparturePoint} - {flight.Destination}";
                FlightsViewListBox.Items.Add(displayFlight);
            }
        }

        /// <summary>
        /// Обновление данных в текстовых полях по указанному полёту.
        /// </summary>
        /// <param name="flight">Лист полётов.</param>
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

            FlightsViewListBox.Items.Clear();

            foreach (var flight in _newFlights)
            {
                string addingFlight = $"{flight.DepartureTime.ToString()} : {flight.DeparturePoint} - {flight.Destination}";
                FlightsViewListBox.Items.Add(addingFlight);
            }

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
                int selectedIndex = FlightsViewListBox.SelectedIndex;
                _newFlights.RemoveAt(selectedIndex);

                FlightsViewListBox.Items.Clear();

                foreach (var flight in _newFlights)
                {
                    string addingFlight = $"{flight.DepartureTime.ToString()}  : {flight.DeparturePoint} - {flight.Destination}";
                    FlightsViewListBox.Items.Add(addingFlight);
                }

                if (selectedIndex < FlightsViewListBox.Items.Count)
                {
                    FlightsViewListBox.SelectedIndex = selectedIndex;
                }
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
                    FlightsViewListBox.Items[FlightsViewListBox.SelectedIndex] = $"{flight.DepartureTime.ToString()} : {flight.DeparturePoint} - {flight.Destination}";
                }
                else
                {
                    DPTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch
            {

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
                    FlightsViewListBox.Items[FlightsViewListBox.SelectedIndex] = $"{flight.DepartureTime.ToString()}: {flight.DeparturePoint} - {flight.Destination}";
                }
                else
                {
                    DestinationTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch
            {

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

            FlightsViewListBoxSort(_newFlights);
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
                //FlightTimeTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Изменение типа рейса.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FlightsViewListBox.SelectedItem != null)
            {
                _newFlights[FlightsViewListBox.SelectedIndex].FlightType = (FlightType)Enum.GetValues(typeof(FlightType)).GetValue
                (FTypeComboBox.SelectedIndex);
                FTypeComboBox.SelectedIndex = (int)_newFlights[FlightsViewListBox.SelectedIndex].FlightType;
            }
        }


        /// <summary>
        /// Изменение иконки авиакомпании.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AirlinePictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы изображений|*.png;*.jpg;*.jpeg;*.gif;*.bmp|Все файлы|*.*";
            openFileDialog.Title = "Выберите изображение";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                AirlinePictureBox.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
                if (FlightsViewListBox.SelectedItem != null)
                {
                    _newFlights[FlightsViewListBox.SelectedIndex].Airline = new System.Drawing.Bitmap(openFileDialog.FileName);
                }

            }
        }

        /// <summary>
        /// Поиск по городам с помощью кнопки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                FlightsViewListBox.Items.Clear();

                foreach (var flight in _newFlights)
                {
                    if (flight.DeparturePoint.Contains(searchTerm) || flight.Destination.Contains(searchTerm))
                    {
                        string displayFlight = $"{flight.DepartureTime.ToString()}: {flight.DeparturePoint} - {flight.Destination}";
                        FlightsViewListBox.Items.Add(displayFlight);
                    }
                }
            }
            else
            {
                DisplayAllFlights();
            }
        }

        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
            DisplayAllFlights();
        }
    }
}