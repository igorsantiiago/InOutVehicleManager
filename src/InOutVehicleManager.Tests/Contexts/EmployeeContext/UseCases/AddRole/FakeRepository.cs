using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AddRole.Contracts;

namespace InOutVehicleManager.Tests.Contexts.EmployeeContext.UseCases.AddRole;

public class FakeRepository : IRepository
{
    protected static readonly Guid _GuidRegistered = new("4f1c7b8d-8b7c-4e3a-9cbb-3ca3a2e4a2db");
    private readonly Employee? _employee = new("Douglas", "Adams", "01234567890", "douglas.adams@contato.com", null);
    private readonly Role _role = new("Admin");

    public Task<Employee?> GetEmployeeByIdAsync(Guid employeeId, CancellationToken cancellationToken)
    {
        if (employeeId == _GuidRegistered)
            return Task.FromResult(_employee);

        return Task.FromResult<Employee?>(null);
    }

    public Task<Role?> GetRoleByNameAsync(string role, CancellationToken cancellationToken)
    {
        if (role == _role.Name)
            return Task.FromResult<Role?>(_role);

        return Task.FromResult<Role?>(null);
    }

    public Task SaveAsync(Employee employee, CancellationToken cancellationToken)
    {
        if (employee is null)
            return Task.FromResult(false);

        return Task.FromResult(true);
    }
}
