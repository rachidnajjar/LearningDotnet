using CustomerWebApi.Domain.Entities;

namespace CustomerWebApi.Messaging.Send.Sender.v1
{
    public interface ICustomerUpdateSender
    {
         void SendCustomer(Customer customer);
    }
}