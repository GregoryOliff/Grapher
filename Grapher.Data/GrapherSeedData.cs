using System;
using System.Collections.Generic;
using System.Linq;
using Grapher.Core.Models;

namespace Grapher.Data
{
    public static class GrapherSeedData
    {
        public static void EnsureSeedData(this GrapherContext db)
        {
            if (!db.Aircraft.Any())
            {
                var aircrafts = new List<Aircraft>
                {
                    new Aircraft
                    {
                        Name = "Aircraft1",
                        LastServiceDate = new DateTime(2018, 1, 4),
                        LastUsage = new DateTime(2018, 5, 6),
                        Flights = new List<Flights>
                        {
                            new Flight
                            {
                                FlightStartTime = DateTime.Now(),
                                FlightEndTime = DateTime.Now().AddHours(1),
                                RecordedSpeeds = new List<double>
                                {
                                    0.0,
                                    150.0,
                                    200.0,
                                    450.0,
                                    580.0,
                                    750.0,
                                    760.0,
                                    900.0,
                                    780.0,
                                    600.0,
                                    300.0,
                                    200.0,
                                    50.0,
                                    0.0
                                },
                                FuelUsed = 26.0,
                                Description = "Test flight that lasted one hour"
                            };

                            new Flight
                            {
                                FlightStartTime = DateTime.Now().AddDays(5),
                                FlightEndTime = DateTime.Now().AddDays(5).AddHours(3),
                                RecordedSpeeds = new List<double>
                                {
                                    0.0,
                                    150.0,
                                    200.0,
                                    450.0,
                                    580.0,
                                    750.0,
                                    760.0,
                                    900.0,
                                    780.0,
                                    800.0,
                                    850.0,
                                    780.0,
                                    600.0,
                                    300.0,
                                    200.0,
                                    50.0,
                                    0.0
                                },
                                FuelUsed = 78.0,
                                Description = "3 hour Test flight"
                            };
                        };
                    };

                    new Aircraft
                    {
                        Name = "Aircraft2",
                        LastServiceDate = new DateTime(2018, 2, 4),
                        LastUsage = new DateTime(2018, 8, 6),
                        Flights = new List<Flights>
                        {
                            new Flight
                            {
                                FlightStartTime = DateTime.Now(),
                                FlightEndTime = DateTime.Now().AddHours(2),
                                RecordedSpeeds = new List<double>
                                {
                                    0.0,
                                    150.0,
                                    200.0,
                                    450.0,
                                    580.0,
                                    752.0,
                                    760.0,
                                    904.0,
                                    781.0,
                                    600.0,
                                    323.0,
                                    200.0,
                                    50.0,
                                    0.0
                                },
                                FuelUsed = 30.0,
                                Description = "Test flight that lasted one hour"
                            };
    
                            new Flight
                            {
                                FlightStartTime = DateTime.Now().AddDays(4),
                                FlightEndTime = DateTime.Now().AddDays(4).AddHours(4),
                                RecordedSpeeds = new List<double>
                                {
                                    0.0,
                                    150.0,
                                    220.0,
                                    450.0,
                                    580.0,
                                    770.0,
                                    760.0,
                                    900.0,
                                    720.0,
                                    800.0,
                                    830.0,
                                    780.0,
                                    630.0,
                                    300.0,
                                    200.0,
                                    50.0,
                                    0.0
                                },
                                FuelUsed = 80.0,
                                Description = "4 hour Test flight"
                            };
                        };
                    };

                };
                db.Aircrafts.AddRange(Aircraft);
                db.SaveChanges();
            }

            if (!db.Flights.Any())
            {
                var flights = new List<Flight>
                {
                    new Flight
                    {
                        FlightStartTime = DateTime.Now(),
                        FlightEndTime = DateTime.Now().AddHours(1),
                        RecordedSpeeds = new List<double>
                        {
                            0.0,
                            150.0,
                            200.0,
                            450.0,
                            580.0,
                            750.0,
                            760.0,
                            900.0,
                            780.0,
                            600.0,
                            300.0,
                            200.0,
                            50.0,
                            0.0
                        },
                        FuelUsed = 26.0,
                        Description = "Test flight that lasted one hour"
                    };

                    new Flight
                    {
                        FlightStartTime = DateTime.Now().AddDays(5),
                        FlightEndTime = DateTime.Now().AddDays(5).AddHours(3),
                        RecordedSpeeds = new List<double>
                        {
                            0.0,
                            150.0,
                            200.0,
                            450.0,
                            580.0,
                            750.0,
                            760.0,
                            900.0,
                            780.0,
                            800.0,
                            850.0,
                            780.0,
                            600.0,
                            300.0,
                            200.0,
                            50.0,
                            0.0
                        },
                        FuelUsed = 78.0,
                        Description = "3 hour Test flight"
                    };
                    new Flight
                    {
                        FlightStartTime = DateTime.Now(),
                        FlightEndTime = DateTime.Now().AddHours(2),
                        RecordedSpeeds = new List<double>
                        {
                            0.0,
                            150.0,
                            200.0,
                            450.0,
                            580.0,
                            752.0,
                            760.0,
                            904.0,
                            781.0,
                            600.0,
                            323.0,
                            200.0,
                            50.0,
                            0.0
                        },
                        FuelUsed = 30.0,
                        Description = "Test flight that lasted one hour"
                    };
    
                    new Flight
                    {
                        FlightStartTime = DateTime.Now().AddDays(4),
                        FlightEndTime = DateTime.Now().AddDays(4).AddHours(4),
                        RecordedSpeeds = new List<double>
                        {
                            0.0,
                            150.0,
                            220.0,
                            450.0,
                            580.0,
                            770.0,
                            760.0,
                            900.0,
                            720.0,
                            800.0,
                            830.0,
                            780.0,
                            630.0,
                            300.0,
                            200.0,
                            50.0,
                            0.0
                        },
                        FuelUsed = 80.0,
                        Description = "4 hour Test flight"
                    };
                }
                db.Flights.AddRange(flights);
                db.SaveChanges();
            }
        }
    }
}  