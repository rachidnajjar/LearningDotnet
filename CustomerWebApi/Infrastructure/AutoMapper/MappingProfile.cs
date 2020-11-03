using AutoMapper;
using CustomerWebApi.Domain.Entities;
using CustomerWebApi.Models.v1;

namespace CustomerWebApi.Infrastructure.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCustomerModel, Customer>().ForMember(x => x.Id, opt => opt.Ignore());

            CreateMap<UpdateCustomerModel, Customer>();
        }
    }
}