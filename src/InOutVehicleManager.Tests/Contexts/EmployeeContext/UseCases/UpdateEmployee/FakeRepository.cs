using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Contracts;

namespace InOutVehicleManager.Tests.Contexts.EmployeeContext.UseCases.UpdateEmployee;

public class FakeRepository : IRepository
{
    protected static readonly Guid _GuidRegistered = new("4f1c7b8d-8b7c-4e3a-9cbb-3ca3a2e4a2db");
    private readonly Employee? _emailExists = new("Douglas", "Adams", "emailexists@contato.com", null, null);
    private readonly Employee? _employee = new("Douglas", "Adams", "contato@contato.com", null, null);

    public Task<bool> AnyAsync(string emailAddress, CancellationToken cancellationToken)
    {
        if (emailAddress == _emailExists?.Email.Address)
            return Task.FromResult(true);

        return Task.FromResult(false);
    }

    public Task<Employee?> GetEmployeeById(Guid id, CancellationToken cancellationToken)
    {
        if (id == _GuidRegistered)
            return Task.FromResult(_employee);

        return Task.FromResult<Employee?>(null);
    }

    public Task SaveAsync(Employee employee, CancellationToken cancellationToken)
    {
        if (employee == null)
            return Task.FromResult(false);

        return Task.FromResult(true);
    }
}
