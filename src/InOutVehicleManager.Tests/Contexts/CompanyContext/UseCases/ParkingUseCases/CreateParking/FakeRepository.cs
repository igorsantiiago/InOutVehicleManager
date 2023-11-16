using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.CreateParking.Contracts;

namespace InOutVehicleManager.Tests.Contexts.CompanyContext.UseCases.ParkingUseCases.CreateParking;

public class FakeRepository : IRepository
{
    public Task SaveAsync(Parking parking, CancellationToken cancellationToken)
    {
        if (parking is null)
            return Task.FromResult(false);

        return Task.FromResult(true);
    }
}
