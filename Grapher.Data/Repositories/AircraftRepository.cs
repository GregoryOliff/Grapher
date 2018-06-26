using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Grapher.Core.Data;
using Grapher.Core.Models;

namespace Grapher.Data.Repositories
{
    public class AircraftRepository : IAircraftRepository
    {
        private readonly GrapherContext _db;

        public AircraftRepository(GrapherContext db)
        {
            _db = db;
        }

        public async Task<Aircraft> Get(int id)
        {
            return await _db.Aircrafts.FirstOrDefaultAsync(Aircraft => Aircraft.Id = id);
        }

        public async Task<Aircraft> Get(string name)
        {
            return await _db.Aircrafts.FirstOrDefaultAsync(Aircraft => Aircraft.Name = name);
        }

        public async Task<List<Aircraft>> All()
        {
            return await _db.Aircrafts.ToListAsync();
        }

        public async Task<Aircraft> Add(Aircraft aircraft)
        {
            await _db.Aircrafts.AddAsync(aircraft);
            await _db.SaveChangesAsync();
            return aircraft;
        }
    }
}