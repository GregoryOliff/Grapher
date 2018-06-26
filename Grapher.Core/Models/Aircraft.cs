using System;
using System.Collections.Generic;

namespace Grapher.Core.Models
{
    public class Aircraft
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime LastServiceDate { get; set; }
        public DateTime LastUsage { get; set; } 
        public List<Flight> Flights { get; set; }
    }
}