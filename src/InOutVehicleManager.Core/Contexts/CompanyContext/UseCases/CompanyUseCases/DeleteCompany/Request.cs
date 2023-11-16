using MediatR;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.DeleteCompany;

public record Request(Guid Id) : IRequest<Response>;
