using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.DeleteCompany.Contracts;
using Microsoft.EntityFrameworkCore;

namespace InOutVehicleManager.Infra.Contexts.CompanyContext.UseCases.CompanyUseCases.DeleteCompany;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context)
    {
        _context = context;
    }

    public async Task DeleteCompany(Company company, CancellationToken cancellationToken)
    {
        _context.Companies.Remove(company);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task<Company?> GetCompanyByIdAsync(Guid id, CancellationToken cancellationToken)
        => await _context.Companies.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
}
