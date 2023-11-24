using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.RegisterEmployee.Contracts;
using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using Microsoft.EntityFrameworkCore;

namespace InOutVehicleManager.Infra.Contexts.CompanyContext.UseCases.CompanyUseCases.RegisterEmployee;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context)
    {
        _context = context;
    }

    public async Task<Company?> GetCompanyByCnpj(string companyCnpj, CancellationToken cancellationToken)
        => await _context.Companies.FirstOrDefaultAsync(x => x.Cnpj.Document == companyCnpj, cancellationToken);
    public async Task<Employee?> GetEmployeeByCpf(string employeeCpf, CancellationToken cancellationToken)
        => await _context.Employees.FirstOrDefaultAsync(x => x.Document.Cpf == employeeCpf, cancellationToken);

    public async Task SaveAsync(Company company, CancellationToken cancellationToken)
    {
        _context.Companies.Update(company);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
