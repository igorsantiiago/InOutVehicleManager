using MediatR;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.DeleteEmployee;

public record Request(Guid Id) : IRequest<Response>;
