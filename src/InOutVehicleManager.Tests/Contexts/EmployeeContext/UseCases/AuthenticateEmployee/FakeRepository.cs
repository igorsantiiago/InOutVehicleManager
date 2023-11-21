using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee.Contracts;

namespace InOutVehicleManager.Tests.Contexts.EmployeeContext.UseCases.AuthenticateEmployee;

public class FakeRepository : IRepository
{
    protected static readonly Guid _GuidRegistered = new("4f1c7b8d-8b7c-4e3a-9cbb-3ca3a2e4a2db");
    private readonly Employee? _employee = new("Douglas", "Adams", "douglasadams@contato.com", "aBcD1#2$3%4^5&6*7(8)9_0+QWERTY");

    public Task<Employee?> GetEmployeeByEmail(string email, CancellationToken cancellationToken)
    {
        if (email == _employee?.Email.Address)
            return Task.FromResult<Employee?>(_employee);

        return Task.FromResult<Employee?>(null);
    }
}
