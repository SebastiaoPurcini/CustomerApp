using CustomerApp.Core.Interfaces;
using CustomerApp.Core.Models;
using CustomerApp.Core.Services.API;
using CustomerApp.Core.Services.JsonConverter;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerApp.Infra.Repositories
{
    public class CityRepository : ICityRepository
    {
        public Task<City> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<City>> GetByState(string state)
        {
            return await JsonConverter.GetJsonToObjectList<City>(await ResponseIBGE.GetContent($"estados/{state}/distritos"));
        }

        public async Task<List<City>> GetAll()
        {
            return await JsonConverter.GetJsonToObjectList<City>(await ResponseIBGE.GetContent("distritos"));
        }
    }
}
