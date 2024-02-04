namespace CleanArchitecture.Application.Interfaces.Repositories;

public interface IUnitOfWork
{
    Task Save(CancellationToken cancellationToken);
}