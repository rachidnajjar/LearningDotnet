
using System.Threading;
using System.Threading.Tasks;
using CustomerWebApi.Data.Repository.v1;
using CustomerWebApi.Domain.Entities;
using MediatR;

namespace CustomerWebApi.Service.v1.Command
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Customer>
    {
        private readonly ICustomerRepository _customerRepository;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            return await _customerRepository.AddAsync(request.Customer);
        }
    }
}