using System.Threading;
using System.Threading.Tasks;
using CustomerWebApi.Data.Repository.v1;
using CustomerWebApi.Domain.Entities;
using CustomerWebApi.Messaging.Send.Sender.v1;
using MediatR;

namespace CustomerWebApi.Service.v1.Command
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, Customer>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICustomerUpdateSender _customerUpdateSender;
        
        public UpdateCustomerCommandHandler(ICustomerUpdateSender customerUpdateSender, ICustomerRepository customerRepository)
        {
            _customerUpdateSender = customerUpdateSender;
            _customerRepository = customerRepository;
        }


        public async Task<Customer> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.UpdateAsync(request.Customer);

            _customerUpdateSender.SendCustomer(customer);

            return customer;
        }
    }
}