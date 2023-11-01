using MediatR;

namespace InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.DeleteVehicle;

public record Request(Guid Id) : IRequest<Response>;