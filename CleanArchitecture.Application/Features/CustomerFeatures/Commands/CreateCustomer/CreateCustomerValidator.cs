using FluentValidation;

namespace CleanArchitecture.Application.Features.CustomerFeatures.Commands.CreateCustomer;

public sealed class CreateCustomerValidator : AbstractValidator<CreateCustomerRequest>
{
    public CreateCustomerValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty().MinimumLength(5).MaximumLength(50);
        RuleFor(x => x.LastName).NotEmpty().MinimumLength(5).MaximumLength(50);
        RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
    }
}