using MediatR;

namespace InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.UpdateVehicle;

public record Request(Guid Id, string Model, string Brand, string Color, string LicensePlate, string Type) : IRequest<Response>;