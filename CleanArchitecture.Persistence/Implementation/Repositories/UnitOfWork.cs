using CleanArchitecture.Application.Interfaces.Repositories;
using CleanArchitecture.Persistence.Context;

namespace CleanArchitecture.Persistence.Implementation.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly DataContext _context;

    public UnitOfWork(DataContext context)
    {
        _context = context;
    }
    public Task Save(CancellationToken cancellationToken)
    {
        return _context.SaveChangesAsync(cancellationToken);
    }
}