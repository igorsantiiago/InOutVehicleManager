using InOutVehicleManager.Core.Contexts.VehicleContext.Entities;
using InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.SearchVehicle.Contracts;
using Microsoft.EntityFrameworkCore;

namespace InOutVehicleManager.Infra.Contexts.VehicleContext.UseCases.SearchVehicle;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context)
    {
        _context = context;
    }

    public async Task<Vehicle?> GetVehicleByIdAsync(Guid id, CancellationToken cancellationToken)
        => await _context.Vehicles.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
}
