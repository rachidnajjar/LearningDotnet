using System;
using System.Threading;
using System.Threading.Tasks;
using CustomerWebApi.Domain.Entities;

namespace CustomerWebApi.Data.Repository.v1
{
    public interface ICustomerRepository : IRepository<Customer>
    {
         Task<Customer> GetCustomerByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}