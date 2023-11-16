using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.CreateParking.Contracts;

public interface IRepository
{
    Task SaveAsync(Parking parking, CancellationToken cancellationToken);
}
