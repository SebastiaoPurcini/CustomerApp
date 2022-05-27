using CustomerApp.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerApp.Core.Interfaces
{
    public interface ICityRepository
    {
        Task<City> GetById(int id);
        Task<List<City>> GetByState(string state);
        Task<List<City>> GetAll();
    }
}
