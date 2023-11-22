using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.RemoveRole.Contracts;

public interface IRepository
{
    Task<Employee?> GetEmployeeByIdAsync(Guid employeeId, CancellationToken cancellationToken);
    Task<Role?> GetRoleByNameAsync(string role, CancellationToken cancellationToken);
    Task RemoveRole(Employee employee, Role role, CancellationToken cancellationToken);
}
