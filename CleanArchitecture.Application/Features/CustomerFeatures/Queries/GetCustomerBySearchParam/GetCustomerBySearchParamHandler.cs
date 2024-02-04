using AutoMapper;
using CleanArchitecture.Application.Common.Exceptions;
using CleanArchitecture.Application.Features.CustomerFeatures.Contracts;
using CleanArchitecture.Application.Interfaces.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.CustomerFeatures.Queries.GetCustomerBySearchParam;

public sealed class GetCustomerBySearchParamHandler : IRequestHandler<GetCustomerBySearchParamRequest, CustomerResponse>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IMapper _mapper;

    public GetCustomerBySearchParamHandler(ICustomerRepository customerRepository, IMapper mapper)
    {
        _customerRepository = customerRepository;
        _mapper = mapper;
    }
    
    public async Task<CustomerResponse> Handle(GetCustomerBySearchParamRequest request, CancellationToken cancellationToken)
    {
        var customer = await _customerRepository.GetBySearchParameter(request.SearchParam, cancellationToken);
        if (customer == null)
        {
            throw new NotFoundException("Customer not found");
        }
        return _mapper.Map<CustomerResponse>(customer);
    }
}