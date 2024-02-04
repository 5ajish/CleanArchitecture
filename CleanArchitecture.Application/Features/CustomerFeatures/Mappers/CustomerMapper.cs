using AutoMapper;
using CleanArchitecture.Application.Features.CustomerFeatures.Commands.CreateCustomer;
using CleanArchitecture.Application.Features.CustomerFeatures.Contracts;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.CustomerFeatures.Mappers;

public sealed class CustomerMapper : Profile
{
    public CustomerMapper()
    {
        CreateMap<CreateCustomerRequest, Customer>();
        CreateMap<Customer, CustomerResponse>()
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));
    }
}