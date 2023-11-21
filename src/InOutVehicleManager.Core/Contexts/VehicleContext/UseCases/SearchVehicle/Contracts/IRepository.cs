using InOutVehicleManager.Core.Contexts.VehicleContext.Entities;

namespace InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.SearchVehicle.Contracts;

public interface IRepository
{
    Task<Vehicle?> GetVehicleByIdAsync(Guid id, CancellationToken cancellationToken);
}
