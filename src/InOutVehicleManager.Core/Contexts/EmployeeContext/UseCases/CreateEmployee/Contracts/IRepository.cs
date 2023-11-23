using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Contracts;

public interface IRepository
{
    Task<bool> AnyCpfAsync(string cpf, CancellationToken cancellationToken);
    Task<bool> AnyEmailAsync(string emailAddress, CancellationToken cancellationToken);
    Task SaveAsync(Employee employee, CancellationToken cancellationToken);
}
