using MediatR;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.UpdateEmployee;

public record Request(Guid Id, string FirstName, string LastName, string EmailAddress) : IRequest<Response>;
