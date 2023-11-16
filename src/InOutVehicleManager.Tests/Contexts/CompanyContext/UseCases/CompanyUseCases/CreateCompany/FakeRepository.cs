using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Contracts;

namespace InOutVehicleManager.Tests.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany;

public class FakeRepository : IRepository
{
    protected static readonly string _CnpjAlreadyExists = new("01230123450001");

    public Task<bool> AnyAsync(string cnpj, CancellationToken cancellationToken)
    {
        if (cnpj == _CnpjAlreadyExists)
            return Task.FromResult(true);

        return Task.FromResult(false);
    }

    public Task SaveAsync(Company company, CancellationToken cancellationToken)
    {
        if (company is null)
            return Task.FromResult(false);

        return Task.FromResult(true);
    }
}
