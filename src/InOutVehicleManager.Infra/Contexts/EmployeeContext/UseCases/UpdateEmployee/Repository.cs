using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Contracts;
using Microsoft.EntityFrameworkCore;

namespace InOutVehicleManager.Infra.Contexts.EmployeeContext.UseCases.UpdateEmployee;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context)
    {
        _context = context;
    }

    public async Task<bool> AnyAsync(string emailAddress, CancellationToken cancellationToken)
        => await _context.Employees.AnyAsync(x => x.Email.Address == emailAddress, cancellationToken);

    public async Task<Employee?> GetEmployeeById(Guid id, CancellationToken cancellationToken)
        => await _context.Employees.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

    public async Task SaveAsync(Employee employee, CancellationToken cancellationToken)
    {
        _context.Employees.Update(employee);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
