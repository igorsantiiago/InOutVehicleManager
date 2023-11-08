using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Contracts;

namespace InOutVehicleManager.Tests.Contexts.EmployeeContext.UseCases.CreateEmployee;

public class FakeRepository : IRepository
{
    private readonly string _email = "contato@contato.com";
    public Task<bool> AnyAsync(string emailAddress, CancellationToken cancellationToken)
    {
        if (emailAddress == _email)
            return Task.FromResult(true);

        return Task.FromResult(false);
    }

    public Task SaveAsync(Employee employee, CancellationToken cancellationToken)
        => Task.FromResult(true);
}
