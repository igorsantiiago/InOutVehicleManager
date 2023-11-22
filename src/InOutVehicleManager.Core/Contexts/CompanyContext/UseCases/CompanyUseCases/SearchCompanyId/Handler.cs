using FluentValidation.Results;
using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.SearchCompanyId.Contracts;
using MediatR;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.SearchCompanyId;

public class Handler : IRequestHandler<Request, Response>
{
    private readonly IRepository _repository;
    private readonly Specification _specification = new();

    public Handler(IRepository repository)
    {
        _repository = repository;
    }

    public async Task<Response> Handle(Request request, CancellationToken cancellationToken)
    {
        #region Validate Request
        try
        {
            ValidationResult result = _specification.Validate(request);
            if (!result.IsValid)
                return new Response("Requisição Inválida.", 400, result.Errors);
        }
        catch
        {
            return new Response("Erro: Falha ao validar a requisição.", 500);
        }
        #endregion

        #region Get Company Id
        Company? company;
        try
        {
            company = await _repository.GetCompanyById(request.Id, cancellationToken);
            if (company is null)
                return new Response("Empresa não encontrada.", 404);
        }
        catch (Exception ex)
        {
            return new Response($"Erro: {ex.Message}", 400);
        }
        #endregion

        #region Response
        return new Response("Empresa encontrada.", new ResponseData(company.Id, company.Name, company.Cnpj.Document, company.Address.ZipCode, company.Address.Street, company.Address.AddressNumber, company.Address.AddressLine, company.Address.City, company.Address.State, company.Phone.LandlinePhone, company.Phone.MobilePhone));
        #endregion
    }
}
