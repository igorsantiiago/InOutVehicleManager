using MediatR;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.DeleteParking;

public record Request(Guid Id) : IRequest<Response>;
