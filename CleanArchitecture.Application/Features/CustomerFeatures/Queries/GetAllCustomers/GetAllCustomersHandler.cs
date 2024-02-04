using AutoMapper;
using CleanArchitecture.Application.Features.CustomerFeatures.Contracts;
using CleanArchitecture.Application.Interfaces.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.CustomerFeatures.Queries.GetAllCustomers;

public sealed class GetAllCustomersHandler : IRequestHandler<GetAllCustomersRequest, List<CustomerResponse>>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IMapper _mapper;

    public GetAllCustomersHandler(ICustomerRepository customerRepository, IMapper mapper)
    {
        _customerRepository = customerRepository;
        _mapper = mapper;
    }
    
    public async Task<List<CustomerResponse>> Handle(GetAllCustomersRequest request, CancellationToken cancellationToken)
    {
        var customers = await _customerRepository.GetAll(cancellationToken);
        return _mapper.Map<List<CustomerResponse>>(customers);
    }
}