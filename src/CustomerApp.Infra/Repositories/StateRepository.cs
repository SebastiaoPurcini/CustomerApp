using CustomerApp.Core.Interfaces;
using CustomerApp.Core.Models;
using CustomerApp.Core.Services.API;
using CustomerApp.Core.Services.JsonConverter;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerApp.Infra.Repositories
{
    public class StateRepository : IStateRepository
    {
        public Task<State> GetByInitial(string initial)
        {
            throw new NotImplementedException();
        }
        public async Task<List<State>> GetAll()
        {
            return await JsonConverter.GetJsonToObjectList<State>(await ResponseIBGE.GetContent("estados"));
        }
    }
}
