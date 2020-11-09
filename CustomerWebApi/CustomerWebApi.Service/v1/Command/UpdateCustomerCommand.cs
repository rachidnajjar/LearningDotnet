using CustomerWebApi.Domain.Entities;
using MediatR;

namespace CustomerWebApi.Service.v1.Command
{
    public class UpdateCustomerCommand : IRequest<Customer>
    {
        public Customer Customer { get; set; }
    }
}