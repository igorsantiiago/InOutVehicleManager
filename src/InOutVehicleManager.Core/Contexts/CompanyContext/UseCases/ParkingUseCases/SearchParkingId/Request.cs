using MediatR;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.SearchParkingId;

public record Request(Guid Id) : IRequest<Response>;
