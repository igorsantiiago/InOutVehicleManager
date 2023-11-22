using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.RemoveRole.Contracts;
using Microsoft.EntityFrameworkCore;

namespace InOutVehicleManager.Infra.Contexts.EmployeeContext.UseCases.RemoveRole;

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

    public async Task RemoveRole(Employee employee, Role role, CancellationToken cancellationToken)
    {
        employee.RemoveRole(role);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
