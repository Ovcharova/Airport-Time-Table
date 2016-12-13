using Airport.Airport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_time_table
{
    public class Flight
    {
        public string Airline;
        public string FlightNumber;
        public DateTime DepartureTime;
        public DateTime ArrivalTime;
        public string DepartureAirport;
        public string ArrivalAirport;
        public string DepatureTerminal;
        public string ArrivalTerminal;
        public Status Status;
        public string Gate;
    }
}
