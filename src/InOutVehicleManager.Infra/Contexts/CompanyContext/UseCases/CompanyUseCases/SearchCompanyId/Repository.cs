using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.SearchCompanyId.Contracts;
using Microsoft.EntityFrameworkCore;

namespace InOutVehicleManager.Infra.Contexts.CompanyContext.UseCases.CompanyUseCases.SearchCompanyId;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context)
    {
        _context = context;
    }

    public async Task<Company?> GetCompanyById(Guid id, CancellationToken cancellationToken)
        => await _context.Companies.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
}
