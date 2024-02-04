using MediatR;

namespace CleanArchitecture.Application.Features.CustomerFeatures.Commands.CreateCustomer;

public sealed record CreateCustomerRequest(string FirstName, string LastName, string Email) : IRequest<Guid>;