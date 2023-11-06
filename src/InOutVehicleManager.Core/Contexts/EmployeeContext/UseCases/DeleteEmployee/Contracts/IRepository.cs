using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.DeleteEmployee.Contracts;

public interface IRepository
{
    Task DeleteEmployee(Employee employee, CancellationToken cancellationToken);
    Task<Employee?> GetEmployeeById(Guid id, CancellationToken cancellationToken);
}
