using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.CreateParking.Contracts;

namespace InOutVehicleManager.Infra.Contexts.CompanyContext.UseCases.ParkingUseCases.CreateParking;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context)
    {
        _context = context;
    }

    public async Task SaveAsync(Parking parking, CancellationToken cancellationToken)
    {
        await _context.Parkings.AddAsync(parking, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
