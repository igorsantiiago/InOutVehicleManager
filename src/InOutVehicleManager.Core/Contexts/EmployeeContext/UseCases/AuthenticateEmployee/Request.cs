using MediatR;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee;

public record Request(string Email, string Password) : IRequest<Response>;
