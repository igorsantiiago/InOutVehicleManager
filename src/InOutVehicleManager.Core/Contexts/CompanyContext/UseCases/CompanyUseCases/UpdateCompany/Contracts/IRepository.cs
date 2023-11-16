using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Contracts;

public interface IRepository
{
    Task<Company?> GetCompanyByIdAsync(Guid id, CancellationToken cancellationToken);
    Task SaveAsync(Company company, CancellationToken cancellationToken);
}
