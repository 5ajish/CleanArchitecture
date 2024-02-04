using CleanArchitecture.Application.Features.CustomerFeatures.Contracts;
using MediatR;

namespace CleanArchitecture.Application.Features.CustomerFeatures.Queries.GetAllCustomers;

public sealed record GetAllCustomersRequest : IRequest<List<CustomerResponse>>;