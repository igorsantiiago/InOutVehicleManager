using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Contracts;

public interface IRepository
{
    Task<bool> AnyAsync(string emailAddress, CancellationToken cancellationToken);
    Task SaveAsync(Employee employee, CancellationToken cancellationToken);
}
