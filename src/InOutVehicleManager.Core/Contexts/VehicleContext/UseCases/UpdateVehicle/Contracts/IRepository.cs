using InOutVehicleManager.Core.Contexts.VehicleContext.Entities;

namespace InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Contracts;

public interface IRepository
{
    Task<Vehicle?> GetVehicleByIdAsync(Guid id, CancellationToken cancellationToken);
    Task SaveAsync(Vehicle vehicle, CancellationToken cancellationToken);
}
