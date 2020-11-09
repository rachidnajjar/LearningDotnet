using System;
using CustomerWebApi.Domain.Entities;
using MediatR;

namespace CustomerWebApi.Service.v1.Query
{
    public class GetCustomerByIdQuery : IRequest<Customer>
    {
        public Guid Id { get; set; }
    }
}