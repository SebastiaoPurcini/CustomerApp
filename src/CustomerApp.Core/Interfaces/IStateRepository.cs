using CustomerApp.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerApp.Core.Interfaces
{
    public interface IStateRepository
    {
        Task<State> GetByInitial(string initial);
        Task<List<State>> GetAll();       
    }
}
