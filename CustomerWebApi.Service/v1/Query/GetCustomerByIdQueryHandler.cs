using System.Threading;
using System.Threading.Tasks;
using CustomerWebApi.Data.Repository.v1;
using CustomerWebApi.Domain.Entities;
using MediatR;

namespace CustomerWebApi.Service.v1.Query
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, Customer>
    {
        private readonly ICustomerRepository _customerRepository;
        
        public GetCustomerByIdQueryHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }


        public async Task<Customer> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            return await _customerRepository.GetCustomerByIdAsync(request.Id, cancellationToken);
        }
    }
}