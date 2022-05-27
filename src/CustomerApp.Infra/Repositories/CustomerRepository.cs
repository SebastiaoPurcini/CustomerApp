using CustomerApp.Core.Interfaces;
using CustomerApp.Core.Models;
using CustomerApp.Infra.Contexts;

namespace CustomerApp.Infra.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext dbContext) : base(dbContext) 
        {  
        }
    }
}
