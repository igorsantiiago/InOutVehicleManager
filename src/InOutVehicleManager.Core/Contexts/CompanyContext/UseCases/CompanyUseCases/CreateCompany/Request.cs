using MediatR;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany;

public record Request(
    string Name,
    string Cnpj,
    string Zipcode, string Street, int AddressNumber, string AddressLine, string City, string State,
    string? LandlinePhone = null, string? MobilePhone = null
    ) : IRequest<Response>;
