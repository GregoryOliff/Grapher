using Microsoft.EntityFrameworkCore;
using Grapher.Core.Models;

namespace Grapher.Data
{
    public sealed class GrapherContext : DbContext
    {
        public GrapherContext(DbContextOptions options)
            : base(options)
        {
            //mutually exclusive
            Database.Migrate();
        }

        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Flight> Flights { get; set; } 
    }
}