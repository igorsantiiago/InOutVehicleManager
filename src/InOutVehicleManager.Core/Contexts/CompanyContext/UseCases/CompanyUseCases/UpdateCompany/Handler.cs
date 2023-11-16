using FluentValidation.Results;
using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Contracts;
using MediatR;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany;

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
            return new Response("Falha em validar a requisição.", 500);
        }
        #endregion

        #region Get Company
        Company? company;
        try
        {
            company = await _repository.GetCompanyByIdAsync(request.Id, cancellationToken);
            if (company == null)
                return new Response("Empresa não encontrada.", 404);
        }
        catch
        {
            return new Response("Falha ao buscar a empresa.", 500);
        }
        #endregion

        #region Update Company
        try
        {
            company = UpdateCompany(company, request);
            await _repository.SaveAsync(company, cancellationToken);
        }
        catch (Exception ex)
        {
            return new Response(ex.Message, 400);
        }
        #endregion

        #region Response
        return new Response("Os dados da empresa foram atualizados com sucesso.", new ResponseData(company.Id, company.Name, company.Cnpj.ToString(), company.IdParking));
        #endregion
    }

    private static Company UpdateCompany(Company company, Request request)
    {
        company.UpdateName(request.Name);
        company.UpdateCnpj(request.Cnpj);
        company.UpdateAddress(
            request.Zipcode,
            request.Street,
            request.AddressNumber,
            request.AddressLine,
            request.City,
            request.State
        );
        company.UpdatePhone(request.LandlinePhone, request.MobilePhone);

        return company;
    }
}
