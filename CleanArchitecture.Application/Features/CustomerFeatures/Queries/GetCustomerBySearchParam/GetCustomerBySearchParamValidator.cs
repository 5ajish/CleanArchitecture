using FluentValidation;

namespace CleanArchitecture.Application.Features.CustomerFeatures.Queries.GetCustomerBySearchParam;

public sealed class GetCustomerBySearchParamValidator : AbstractValidator<GetCustomerBySearchParamRequest>
{
    public GetCustomerBySearchParamValidator()
    {
        RuleFor(x => x.SearchParam).NotEmpty().MinimumLength(3).MaximumLength(50);
    }
}