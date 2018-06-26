using System.Collections.Generic;
using System.Threading.Tasks;
using Grapher.Core.Models;

namespace Grapher.core.Data
{
    public interface IFlightRepository
    {
        Task<List<Flight>> Get(DateTime dateTime);
        Task<Flight> Get(int id);
        Task<List<Flight>> All();
        Task<Flight> Add(Flight flight);
    }
}