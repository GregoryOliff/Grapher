using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Grapher.Core.Data;
using Grapher.Core.Models;

namespace Grapher.Data.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        private readonly GrapherContext _db;

        public FlightRepository(GrapherContext db)
        {
            _db = db;
        }

        public async Task<Flight> Get(int id)
        {
            return await _db.Flights.FirstOrDefaultAsync(Flight => Flight.Id => id);
        }

        public async Task<List<Flight>> Get(DateTime datetime)
        {
            return await _db.Flights.ToListAsync(Flight => Flight.FlightStartTime = datetime);
        }

        public async Task<List<Flight>> All()
        {
            return await _db.Flights.ToListAsync();
        }

        public async Task<Flight> Add(Flight flight)
        {
            await _db.Flights.AddAsync(flight);
            await _db.SaveChangesAsync();
            return flight
        }
    }
}