namespace CleanArchitecture.Application.Features.CustomerFeatures.Contracts;

public sealed record CustomerResponse
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string FullName { get; set; }
}