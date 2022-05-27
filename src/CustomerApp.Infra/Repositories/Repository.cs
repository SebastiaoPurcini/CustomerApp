using CustomerApp.Core.Interfaces;
using CustomerApp.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerApp.Infra.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly AppDbContext dbContext;
        private readonly DbSet<TEntity> repDbSet;

        public Repository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            repDbSet = dbContext.Set<TEntity>();
        }
        public async Task Create(TEntity obj)
        {
            repDbSet.Add(obj);
            await dbContext.SaveChangesAsync();
        }

        public async Task Update(TEntity obj)
        {
            repDbSet.Update(obj);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var obj = await repDbSet.FindAsync(id);

            repDbSet.Remove(obj);
            await dbContext.SaveChangesAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await repDbSet.FindAsync(id);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await repDbSet.ToListAsync();
        }

        public void Dispose()
        {
            dbContext?.Dispose();
        }
    }
}
