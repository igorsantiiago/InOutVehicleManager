using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AddRole.Contracts;

public interface IRepository
{
    Task<Employee?> GetEmployeeByIdAsync(Guid employeeId, CancellationToken cancellationToken);
    Task<Role?> GetRoleByNameAsync(string role, CancellationToken cancellationToken);
    Task SaveAsync(Employee employee, CancellationToken cancellationToken);
}
