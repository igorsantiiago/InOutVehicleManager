using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.DeleteEmployee.Contracts;

namespace InOutVehicleManager.Tests.Contexts.EmployeeContext.UseCases.DeleteEmployee;

public class FakeRepository : IRepository
{
    protected static readonly Guid _GuidRegistered = new("4f1c7b8d-8b7c-4e3a-9cbb-3ca3a2e4a2db");
    private readonly Employee? _employee = new("Douglas", "Adams", "douglas.adams@contato.com", null);

    public Task DeleteEmployee(Employee employee, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<Employee?> GetEmployeeById(Guid id, CancellationToken cancellationToken)
    {
        if (id == _GuidRegistered)
            return Task.FromResult(_employee);

        return Task.FromResult<Employee?>(null);
    }
}
