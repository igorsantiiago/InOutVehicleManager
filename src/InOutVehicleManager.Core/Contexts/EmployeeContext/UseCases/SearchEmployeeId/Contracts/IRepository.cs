using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.SearchEmployeeId.Contracts;

public interface IRepository
{
    Task<Employee?> GetEmployeeById(Guid id, CancellationToken cancellationToken);
}
