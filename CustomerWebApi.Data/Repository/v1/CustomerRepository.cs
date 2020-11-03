using System;
using System.Threading;
using System.Threading.Tasks;
using CustomerWebApi.Data.Database;
using CustomerWebApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerWebApi.Data.Repository.v1
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(CustomerContext customerContext) : base(customerContext)
        {
        }
        public async Task<Customer> GetCustomerByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await CustomerContext.Customer.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }
    }
}