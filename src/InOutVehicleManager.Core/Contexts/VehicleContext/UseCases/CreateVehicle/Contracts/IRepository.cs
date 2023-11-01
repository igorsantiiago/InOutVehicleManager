using InOutVehicleManager.Core.Contexts.VehicleContext.Entities;

namespace InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.CreateVehicle.Contracts;

public interface IRepository
{
    Task<bool> AnyAsync(string licensePlate, CancellationToken cancellationToken);
    Task SaveAsync(Vehicle vehicle, CancellationToken cancellationToken);
}
