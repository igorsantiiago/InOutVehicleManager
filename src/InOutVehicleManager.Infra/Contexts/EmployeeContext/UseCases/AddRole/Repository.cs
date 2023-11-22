using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AddRole.Contracts;
using Microsoft.EntityFrameworkCore;

namespace InOutVehicleManager.Infra.Contexts.EmployeeContext.UseCases.AddRole;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context)
    {
        _context = context;
    }

    public async Task<Employee?> GetEmployeeByIdAsync(Guid employeeId, CancellationToken cancellationToken)
        => await _context.Employees.FirstOrDefaultAsync(x => x.Id == employeeId, cancellationToken);

    public async Task<Role?> GetRoleByNameAsync(string role, CancellationToken cancellationToken)
        => await _context.Roles.FirstOrDefaultAsync(x => x.Name == role, cancellationToken);

    public async Task SaveAsync(Employee employee, CancellationToken cancellationToken)
    {
        _context.Employees.Update(employee);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
