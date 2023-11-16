
using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Contracts;

public interface IRepository
{
    Task<bool> AnyAsync(string cnpj, CancellationToken cancellationToken);
    Task SaveAsync(Company company, CancellationToken cancellationToken);
}
