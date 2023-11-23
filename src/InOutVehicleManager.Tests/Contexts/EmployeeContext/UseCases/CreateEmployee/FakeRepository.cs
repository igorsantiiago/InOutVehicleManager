using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Contracts;

namespace InOutVehicleManager.Tests.Contexts.EmployeeContext.UseCases.CreateEmployee;

public class FakeRepository : IRepository
{
    private readonly string _email = "contato@contato.com";
    private readonly string _cpf = "01234567890";

    public Task<bool> AnyCpfAsync(string cpf, CancellationToken cancellationToken)
    {
        if (cpf == _cpf)
            return Task.FromResult(true);

        return Task.FromResult(false);
    }

    public Task<bool> AnyEmailAsync(string emailAddress, CancellationToken cancellationToken)
    {
        if (emailAddress == _email)
            return Task.FromResult(true);

        return Task.FromResult(false);
    }

    public Task SaveAsync(Employee employee, CancellationToken cancellationToken)
        => Task.FromResult(true);
}
