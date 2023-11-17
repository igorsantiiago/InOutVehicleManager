using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.DeleteEmployee.Contracts;
using Microsoft.EntityFrameworkCore;

namespace InOutVehicleManager.Infra.Contexts.EmployeeContext.UseCases.DeleteEmployee;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context)
    {
        _context = context;
    }

    public async Task DeleteEmployee(Employee employee, CancellationToken cancellationToken)
    {
        _context.Employees.Remove(employee);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task<Employee?> GetEmployeeById(Guid id, CancellationToken cancellationToken)
        => await _context.Employees.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
}
