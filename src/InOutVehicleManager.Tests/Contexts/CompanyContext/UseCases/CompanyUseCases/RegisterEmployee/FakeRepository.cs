using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.RegisterEmployee.Contracts;
using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;

namespace InOutVehicleManager.Tests.Contexts.CompanyContext.UseCases.CompanyUseCases.RegisterEmployee;

public class FakeRepository : IRepository
{
    private static readonly Company _company = new("Teste", new("01230123450001"), new("0123456", "Rua Teste", 1234, "Complemento Teste", "Cidade Teste", "Estado Teste"), new("01234567", "012345678"));
    private readonly Employee _employee = new("Douglas", "Adams", "01234567890", "douglas.adams@contato.com", null);

    public Task<Company?> GetCompanyByCnpj(string companyCnpj, CancellationToken cancellationToken)
    {
        if (_company.Cnpj.Document == companyCnpj)
            return Task.FromResult<Company?>(_company);

        return Task.FromResult<Company?>(null);
    }

    public Task<Employee?> GetEmployeeByCpf(string employeeCpf, CancellationToken cancellationToken)
    {
        if (_employee.Document.Cpf == employeeCpf)
            return Task.FromResult<Employee?>(_employee);

        return Task.FromResult<Employee?>(null);
    }

    public Task SaveAsync(Company company, CancellationToken cancellationToken)
    {
        if (company is null)
            return Task.FromResult(false);

        return Task.FromResult(true);
    }
}
