using MediatR;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AddRole;

public record Request(Guid EmployeeId, string Role) : IRequest<Response>;
