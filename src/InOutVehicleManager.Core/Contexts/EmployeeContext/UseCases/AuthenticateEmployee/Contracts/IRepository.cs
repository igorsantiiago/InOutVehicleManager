using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee.Contracts;

public interface IRepository
{
    Task<Employee?> GetEmployeeByEmail(string email, CancellationToken cancellationToken);
}
