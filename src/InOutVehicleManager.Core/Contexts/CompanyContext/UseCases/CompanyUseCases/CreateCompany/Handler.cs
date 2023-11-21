using FluentValidation.Results;
using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Contracts;
using InOutVehicleManager.Core.Contexts.CompanyContext.ValueObjects;
using MediatR;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany;

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
                return new Response("Erro: Requisição Inválida.", 400, result.Errors);
        }
        catch
        {
            return new Response("Erro: Falha ao validar a requisição.", 500);
        }
        #endregion

        #region Check if Company already exists
        try
        {
            var exists = await _repository.AnyAsync(request.Cnpj, cancellationToken);
            if (exists)
                return new Response("Erro: CNPJ já esta cadastrado.", 400);
        }
        catch
        {
            return new Response("Erro: Falha ao verificar a existência do CNPJ.", 500);
        }
        #endregion

        #region Create Company
        Company? company;
        try
        {
            company = CreateCompany(request);

            await _repository.SaveAsync(company, cancellationToken);
        }
        catch (Exception ex)
        {
            return new Response(ex.Message, 400);
        }
        #endregion

        #region Response
        return new Response("Empresa cadastrada com sucesso.", new ResponseData(company.Id, company.Name, company.Cnpj.ToString()));
        #endregion
    }

    private static Company CreateCompany(Request request)
    {
        var cnpj = CreateCnpj(request);
        var adddress = CreateAddress(request);
        var phone = CreatePhone(request);

        Company company = new(request.Name, cnpj, adddress, phone);

        return company;
    }

    private static Cnpj CreateCnpj(Request request)
        => new(request.Cnpj);

    private static Address CreateAddress(Request request)
        => new(request.Zipcode, request.Street, request.AddressNumber, request.AddressLine, request.City, request.State);

    private static Phone CreatePhone(Request request)
        => new(request.LandlinePhone, request.MobilePhone);
}
