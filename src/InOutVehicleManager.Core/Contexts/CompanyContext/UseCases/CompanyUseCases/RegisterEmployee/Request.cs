using MediatR;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.RegisterEmployee;
public record Request(string CompanyCnpj, string EmployeeCpf) : IRequest<Response>;
