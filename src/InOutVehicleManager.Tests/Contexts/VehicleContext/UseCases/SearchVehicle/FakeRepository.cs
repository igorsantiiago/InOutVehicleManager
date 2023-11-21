using InOutVehicleManager.Core.Contexts.VehicleContext.Entities;
using InOutVehicleManager.Core.Contexts.VehicleContext.Enums;
using InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.SearchVehicle.Contracts;

namespace InOutVehicleManager.Tests.Contexts.VehicleContext.UseCases.SearchVehicle;

public class FakeRepository : IRepository
{
    private readonly Guid _customGuid = new("4f1c7b8d-8b7c-4e3a-9cbb-3ca3a2e4a2db");
    private readonly Vehicle _vehicle = new("Panamera", "Porsche", "Grey", "A1B4C2D3", VehicleType.Car);

    public Task<Vehicle?> GetVehicleByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        if (id == _customGuid)
            return Task.FromResult<Vehicle?>(_vehicle);

        return Task.FromResult<Vehicle?>(null);
    }
}
