using Newtonsoft.Json;
using System.Drawing;

public class FlightData
{
    public string DeparturePoint { get; set; }
    public string Destination { get; set; }
    public DateTime DepartureTime { get; set; }
    public int TimeFlight { get; set; }
    public FlightType TypeOfFlight { get; set; }
    public string AirlineBase64 { get; set; }
}