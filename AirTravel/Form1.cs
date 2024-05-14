using AirTravel.Properties;

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
            DTDataTimePicker.Text = Convert.ToString(flight.DepartureTime);
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
            DTDataTimePicker.Text = DateTime.Now.ToString();
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
            string addingFlight = $"����� ������: {newFlight.DeparturePoint} - {newFlight.Destination}";
            FlightsViewListBox.Items.Add(addingFlight);
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
                _newFlights.RemoveAt(FlightsViewListBox.SelectedIndex);
                FlightsViewListBox.Items.RemoveAt(FlightsViewListBox.SelectedIndex);
                ClearFlightInfo();
            }
        }
    }
}