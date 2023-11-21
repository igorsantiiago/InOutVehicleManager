using MediatR;

namespace InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.SearchVehicle;

public record Request(Guid Id) : IRequest<Response>;
