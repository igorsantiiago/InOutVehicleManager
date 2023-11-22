using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.SearchCompanyId.Contracts;

public interface IRepository
{
    Task<Company?> GetCompanyById(Guid id, CancellationToken cancellationToken);
}
