using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.UpdateParking.Contracts;

public interface IRepository
{
    Task<Parking?> GetCompanyParkingByIdAsync(Guid id, CancellationToken cancellationToken);
    Task SaveAsync(Parking parking, CancellationToken cancellationToken);
}
