using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.DeleteParking.Contracts;

public interface IRepository
{
    Task DeleteCompanyParking(Parking parking, CancellationToken cancellationToken);
    Task<Parking?> GetCompanyParkingByIdAsync(Guid id, CancellationToken cancellationToken);
}
