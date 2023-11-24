using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.RegisterEmployee.Contracts;
public interface IRepository
{
    Task<Company?> GetCompanyByCnpj(string companyCnpj, CancellationToken cancellationToken);
    Task<Employee?> GetEmployeeByCpf(string employeeCpf, CancellationToken cancellationToken);
    Task SaveAsync(Company company, CancellationToken cancellationToken);
}
