using InOutVehicleManager.Core.Contexts.VehicleContext.Entities;

namespace InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.DeleteVehicle.Contracts;

public interface IRepository
{
    Task DeleteVehicle(Vehicle vehicle, CancellationToken cancellationToken);
    Task<Vehicle?> GetVehicleByIdAsync(Guid id, CancellationToken cancellationToken);
}
