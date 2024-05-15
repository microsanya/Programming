using AirTravel.Properties;
using System.Windows.Forms;

namespace AirTravel
{
    public partial class AirTravelForm : Form
    {
        /// <summary>
        /// ������������� �����.
        /// </summary>
        public AirTravelForm()
        {
            InitializeComponent();
        }
        // -------------------------------------- ����������� ���. ���������� � ���������� ----------------------------------------------------
        /// <summary>
        /// ���� ������.
        /// </summary>
        private List<Flight> _newFlights = new List<Flight>();

        /// <summary>
        /// ����� ��������� ����.
        /// </summary>
        private Flight _currentFlight = new Flight();

        //------------------------------------------------------ ������ ------------------------------------------------------------------------

        /// <summary>
        /// ���������� �������� �� ������� ������.
        /// </summary>
        /// <param name="flights">���� ������.</param>
        private void FlightsViewListBoxSort(List<Flight> flights)
        {
            int n = flights.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (flights[j].DepartureTime > flights[j + 1].DepartureTime)
                    {
                        Flight tempFlight = flights[j];
                        flights[j] = flights[j + 1];
                        flights[j + 1] = tempFlight;

                        object tempItem = FlightsViewListBox.Items[j];
                        FlightsViewListBox.Items[j] = FlightsViewListBox.Items[j + 1];
                        FlightsViewListBox.Items[j + 1] = tempItem;
                    }
                }
            }
        }

        /// <summary>
        /// ����� ���� ������ ����� ������.
        /// </summary>
        private void DisplayAllFlights()
        {
            // ������� ���������� ����������� ������
            FlightsViewListBox.Items.Clear();

            // ����������� ���� ��������� ������
            foreach (var flight in _newFlights)
            {
                string displayFlight = $"����� ������: {flight.DeparturePoint} - {flight.Destination}";
                FlightsViewListBox.Items.Add(displayFlight);
            }
        }

        /// <summary>
        /// ���������� ������ � ��������� ����� �� ���������� �����.
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
        /// ������� ������ � ����� �� �����.
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
        /// ����� ����� � FlightsViewListBox.
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

            // ����������
            FlightsViewListBoxSort(_newFlights);
        }

        /// <summary>
        /// ���������� ����� � FlightsViewListBox.
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
                string addingFlight = $"����� ������: {flight.DeparturePoint} - {flight.Destination}";
                FlightsViewListBox.Items.Add(addingFlight);
            }

            FlightsViewListBoxSort(_newFlights);
        }

        /// <summary>
        /// ��������� ���� �� ������ ���������� (��������).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonPB_MouseEnter(object sender, EventArgs e)
        {
            AddButtonPB.BackColor = Color.LightGray;
        }

        /// <summary>
        /// ���� �� �� ������ ���������� (��������).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonPB_MouseLeave(object sender, EventArgs e)
        {
            AddButtonPB.BackColor = AirTravelForm.DefaultBackColor;
        }

        /// <summary>
        /// ���� ���� �� ������ (��������).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonPB_MouseClick(object sender, MouseEventArgs e)
        {
            AddButtonPB.BackColor = Color.Gray;
        }

        /// <summary>
        /// �������� ����� �� FlightsViewListBox � ����� ������.
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
                    string addingFlight = $"����� ������: {flight.DeparturePoint} - {flight.Destination}";
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
        /// ��������� ���� �� ������ �������� (��������).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButtonPB_MouseEnter(object sender, EventArgs e)
        {
            DeleteButtonPB.BackColor = Color.LightGray;
        }

        /// <summary>
        /// ���� �� �� ������ �������� (��������).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButtonPB_MouseLeave(object sender, EventArgs e)
        {
            DeleteButtonPB.BackColor = AirTravelForm.DefaultBackColor;
        }

        /// <summary>
        /// ���� �� ������ �������� (��������).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButtonPB_MouseClick(object sender, MouseEventArgs e)
        {
            DeleteButtonPB.BackColor = Color.Gray;
        }

        /// <summary>
        /// ��������� �������� ����� �����������.
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
                    FlightsViewListBox.Items[FlightsViewListBox.SelectedIndex] = $"����� ������: {flight.DeparturePoint} - {flight.Destination}";
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
        /// ��������� �������� ����� ����������.
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
                    FlightsViewListBox.Items[FlightsViewListBox.SelectedIndex] = $"����� ������: {flight.DeparturePoint} - {flight.Destination}";
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
        /// ��������� ���� ������.
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
                    MessageBox.Show("���� �� ����� ���� ������ �����������!");
                }
            }
            catch
            {
                MessageBox.Show("���� �� ����� ���� ������ �����������!");
            }
        }

        /// <summary>
        /// ��������� ������� �����.
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
        /// ��������� ���� �����.
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
        /// ��������� ������ ������������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AirlinePictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "����� �����������|*.png;*.jpg;*.jpeg;*.gif;*.bmp|��� �����|*.*";
            openFileDialog.Title = "�������� �����������";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                AirlinePictureBox.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
                _newFlights[FlightsViewListBox.SelectedIndex].Airline = new System.Drawing.Bitmap(openFileDialog.FileName);
            }
        }

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
                        string displayFlight = $"����� ������: {flight.DeparturePoint} - {flight.Destination}";
                        FlightsViewListBox.Items.Add(displayFlight);
                    }
                }
            }
            else
            {
                DisplayAllFlights();
            }
        }
    }
}