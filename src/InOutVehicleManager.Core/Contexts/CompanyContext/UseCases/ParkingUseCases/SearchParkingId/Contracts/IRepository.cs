using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.SearchParkingId.Contracts;

public interface IRepository
{
    Task<Parking?> GetParkingById(Guid id, CancellationToken cancellationToken);
}
