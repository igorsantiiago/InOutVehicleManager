using InOutVehicleManager.Core.Contexts.VehicleContext.Enums;
using MediatR;

namespace InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.CreateVehicle;

public record Request(string Model, string Brand, string Color, string LicensePlate, string Type) : IRequest<Response>;
