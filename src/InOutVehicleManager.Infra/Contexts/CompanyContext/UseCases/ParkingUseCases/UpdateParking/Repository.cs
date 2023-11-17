using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.UpdateParking.Contracts;
using Microsoft.EntityFrameworkCore;

namespace InOutVehicleManager.Infra.Contexts.CompanyContext.UseCases.ParkingUseCases.UpdateParking;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context)
    {
        _context = context;
    }

    public async Task<Parking?> GetCompanyParkingByIdAsync(Guid id, CancellationToken cancellationToken)
        => await _context.Parkings.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

    public async Task SaveAsync(Parking parking, CancellationToken cancellationToken)
    {
        _context.Parkings.Update(parking);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
