using MediatR;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.SearchEmployeeId;

public record Request(Guid Id) : IRequest<Response>;
