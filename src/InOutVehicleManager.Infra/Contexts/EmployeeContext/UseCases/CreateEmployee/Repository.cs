using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Contracts;
using Microsoft.EntityFrameworkCore;

namespace InOutVehicleManager.Infra.Contexts.EmployeeContext.UseCases.CreateEmployee;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context)
    {
        _context = context;
    }

    public async Task<bool> AnyCpfAsync(string cpf, CancellationToken cancellationToken)
        => await _context.Employees.AsNoTracking().AnyAsync(x => x.Document.Cpf == cpf, cancellationToken);

    public async Task<bool> AnyEmailAsync(string emailAddress, CancellationToken cancellationToken)
        => await _context.Employees.AsNoTracking().AnyAsync(x => x.Email.Address == emailAddress, cancellationToken);

    public async Task SaveAsync(Employee employee, CancellationToken cancellationToken)
    {
        await _context.Employees.AddAsync(employee, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
