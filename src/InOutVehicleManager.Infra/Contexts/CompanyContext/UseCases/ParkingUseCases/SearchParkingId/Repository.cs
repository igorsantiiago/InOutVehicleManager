using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.SearchParkingId.Contracts;
using Microsoft.EntityFrameworkCore;

namespace InOutVehicleManager.Infra.Contexts.CompanyContext.UseCases.ParkingUseCases.SearchParkingId;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context)
    {
        _context = context;
    }

    public async Task<Parking?> GetParkingById(Guid id, CancellationToken cancellationToken)
        => await _context.Parkings.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
}
