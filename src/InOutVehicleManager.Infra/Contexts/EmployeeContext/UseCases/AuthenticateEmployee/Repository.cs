using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee.Contracts;
using Microsoft.EntityFrameworkCore;

namespace InOutVehicleManager.Infra.Contexts.EmployeeContext.UseCases.AuthenticateEmployee;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context)
    {
        _context = context;
    }
    public async Task<Employee?> GetEmployeeByEmail(string email, CancellationToken cancellationToken)
        => await _context.Employees.AsNoTracking().Include(x => x.Roles)
        .FirstOrDefaultAsync(x => x.Email.Address == email, cancellationToken);
}
