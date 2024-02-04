using CleanArchitecture.Application.Features.CustomerFeatures.Contracts;
using MediatR;

namespace CleanArchitecture.Application.Features.CustomerFeatures.Queries.GetCustomerBySearchParam;

public sealed record GetCustomerBySearchParamRequest(string SearchParam) : IRequest<CustomerResponse>;