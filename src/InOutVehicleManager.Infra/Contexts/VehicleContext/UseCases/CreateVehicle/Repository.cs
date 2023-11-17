using InOutVehicleManager.Core.Contexts.VehicleContext.Entities;
using InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.CreateVehicle.Contracts;
using Microsoft.EntityFrameworkCore;

namespace InOutVehicleManager.Infra.Contexts.VehicleContext.UseCases.CreateVehicle;

public class Repository : IRepository
{
    private readonly DataContext _context;

    public Repository(DataContext context)
    {
        _context = context;
    }

    public async Task<bool> AnyAsync(string licensePlate, CancellationToken cancellationToken)
        => await _context.Vehicles.AsNoTracking().AnyAsync(x => x.LicensePlate == licensePlate, cancellationToken);

    public async Task SaveAsync(Vehicle vehicle, CancellationToken cancellationToken)
    {
        await _context.Vehicles.AddAsync(vehicle, cancellationToken);
        await _context.SaveChangesAsync();
    }
}
