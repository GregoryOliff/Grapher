using System;
using System.Collections.Generic;

namespace Grapher.Core.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public DateTime FlightStarTime { get; set; }
        public DateTime FlightEndTime { get; set; }
        public List<double> RecordedSpeeds { get; set; }
        public double FuelUsed { get; set; }
        public string Description { get; set; }
    }
}