using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Contracts;

namespace InOutVehicleManager.Tests.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany;

public class FakeRepository : IRepository
{
    protected static readonly Guid _GuidRegistered = new("4f1c7b8d-8b7c-4e3a-9cbb-3ca3a2e4a2db");
    protected static readonly Company? _company = new Company("Teste", new("023924n30f0001"), new("0123456", "Rua Teste", 1234, "Complemento Teste", "Cidade Teste", "Estado Teste"), new("01234567", "012345678"), null);

    public Task<Company?> GetCompanyByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        if (id == _GuidRegistered)
            return Task.FromResult(_company);

        return Task.FromResult<Company?>(null);
    }

    public Task SaveAsync(Company company, CancellationToken cancellationToken)
    {
        if (company is null)
            return Task.FromResult(false);

        return Task.FromResult(true);
    }
}
