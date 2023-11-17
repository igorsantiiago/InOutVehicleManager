using InOutVehicleManager.Core.Contexts.VehicleContext.Entities;
using InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.DeleteVehicle.Contracts;
using Microsoft.EntityFrameworkCore;

namespace InOutVehicleManager.Infra.Contexts.VehicleContext.UseCases.DeleteVehicle;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context)
    {
        _context = context;
    }
    public async Task DeleteVehicle(Vehicle vehicle, CancellationToken cancellationToken)
    {
        _context.Vehicles.Remove(vehicle);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task<Vehicle?> GetVehicleByIdAsync(Guid id, CancellationToken cancellationToken)
        => await _context.Vehicles.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
}
