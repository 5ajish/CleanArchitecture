using CleanArchitecture.Application.Interfaces.Repositories;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Implementation.Repositories;

public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(DataContext context) : base(context)
    {
    }
    
    public Task<Customer> GetBySearchParameter(string searchParam, CancellationToken cancellationToken)
    {
        return Context.Customers
            .FirstOrDefaultAsync(
                x => x.FirstName.ToLower().Contains(searchParam.ToLower()) ||
                     x.LastName.ToLower().Contains(searchParam.ToLower()),
                cancellationToken
            );
    }
}