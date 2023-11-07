using InOutVehicleManager.Core.Contexts.VehicleContext.Entities;
using InOutVehicleManager.Core.Contexts.VehicleContext.Enums;
using InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.CreateVehicle.Contracts;

namespace InOutVehicleManager.Tests.Contexts.VehicleContext.UseCases.CreateVehicle;

public class FakeRepository : IRepository
{
    private readonly Vehicle _validVehicle = new("Cayenne", "Porsche", "Preta", "X1Y2Z3W4", VehicleType.Car);

    public Task<bool> AnyAsync(string licensePlate, CancellationToken cancellationToken)
    {
        if (licensePlate == _validVehicle.LicensePlate)
            return Task.FromResult(true);

        return Task.FromResult(false);
    }

    public Task SaveAsync(Vehicle vehicle, CancellationToken cancellationToken)
        => Task.FromResult(true);
}
