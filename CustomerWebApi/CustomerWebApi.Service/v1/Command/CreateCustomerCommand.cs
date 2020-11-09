using CustomerWebApi.Domain.Entities;
using MediatR;

namespace CustomerWebApi.Service.v1.Command
{
    public class CreateCustomerCommand : IRequest<Customer>
    {
        public Customer Customer { get; set; }
    }
}