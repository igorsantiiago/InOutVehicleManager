using InOutVehicleManager.Core.Contexts.VehicleContext.Entities;
using InOutVehicleManager.Core.Contexts.VehicleContext.Enums;
using InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.DeleteVehicle.Contracts;

namespace InOutVehicleManager.Tests.Contexts.VehicleContext.UseCases.DeleteVehicle;

public class FakeRepository : IRepository
{
    private readonly Guid _customGuid = new("4f1c7b8d-8b7c-4e3a-9cbb-3ca3a2e4a2db");
    private readonly Vehicle _vehicle = new("Cayenne", "Porsche", "Black", "A1B2C3D4", VehicleType.Car);

    public Task DeleteVehicle(Vehicle vehicle, CancellationToken cancellationToken)
        => Task.FromResult(true);

    public Task<Vehicle?> GetVehicleByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        if (id == _customGuid)
            return Task.FromResult<Vehicle?>(_vehicle);

        return Task.FromResult<Vehicle?>(null);
    }
}
