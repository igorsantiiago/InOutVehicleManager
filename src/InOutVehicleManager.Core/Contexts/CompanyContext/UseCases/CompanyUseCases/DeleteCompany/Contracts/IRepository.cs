using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.DeleteCompany.Contracts;

public interface IRepository
{
    Task DeleteCompany(Company company, CancellationToken cancellationToken);
    Task<Company?> GetCompanyByIdAsync(Guid id, CancellationToken cancellationToken);
}
