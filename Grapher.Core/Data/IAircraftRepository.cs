using System.Collections.Generic;
using System.Threading.Tasks;
using Grapher.Core.Models;

namespace Grapher.Core.Data
{
    public interface IAircraftRepository
    {
        Task<Aircraft> Get(int id);
        Task<Aircraft> Get(string name);
        Task<List<Aircraft>> All();
        Task<Aircraft> Add(Aircraft aircraft);
    }
}