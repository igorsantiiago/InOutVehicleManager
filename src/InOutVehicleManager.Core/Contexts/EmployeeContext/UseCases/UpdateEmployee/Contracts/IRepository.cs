using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Contracts;

public interface IRepository
{
    Task<bool> AnyAsync(string emailAddress, CancellationToken cancellationToken);
    Task<Employee?> GetEmployeeById(Guid id, CancellationToken cancellationToken);
}