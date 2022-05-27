using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerApp.Core.Interfaces
{
    public interface IRepository<TEntity> : IDisposable
    {
        Task Create(TEntity obj);
        Task<TEntity> GetById(int id);
        Task<List<TEntity>> GetAll();
        Task Update(TEntity obj);
        Task Delete(int id);
    }
}
