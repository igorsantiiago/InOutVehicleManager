using InOutVehicleManager.Core.Contexts.VehicleContext.Entities;
using InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Contracts;
using Microsoft.EntityFrameworkCore;

namespace InOutVehicleManager.Infra.Contexts.VehicleContext.UseCases.UpdateVehicle;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context)
    {
        _context = context;
    }

    public async Task<Vehicle?> GetVehicleByIdAsync(Guid id, CancellationToken cancellationToken)
        => await _context.Vehicles.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

    public async Task SaveAsync(Vehicle vehicle, CancellationToken cancellationToken)
    {
        _context.Vehicles.Update(vehicle);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
