using MediatR;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.RemoveRole;

public record Request(Guid EmployeeId, string Role) : IRequest<Response>;
