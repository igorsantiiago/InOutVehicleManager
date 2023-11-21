using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.SearchParkingId.Contracts;

namespace InOutVehicleManager.Tests.Contexts.CompanyContext.UseCases.ParkingUseCases.SearchParkingId;

public class FakeRepository : IRepository
{
    protected static readonly Guid _GuidRegistered = new("4f1c7b8d-8b7c-4e3a-9cbb-3ca3a2e4a2db");
    protected static readonly Parking? _parking = new(10, 20);

    public Task<Parking?> GetParkingById(Guid id, CancellationToken cancellationToken)
    {
        if (id == _GuidRegistered)
            return Task.FromResult(_parking);

        return Task.FromResult<Parking?>(null);
    }
}
