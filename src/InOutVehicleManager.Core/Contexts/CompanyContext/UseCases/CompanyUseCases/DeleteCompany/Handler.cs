using FluentValidation.Results;
using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.DeleteCompany.Contracts;
using MediatR;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.DeleteCompany;

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
            return new Response("Falha ao validar a requisição.", 500);
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
            return new Response("Falha ao buscar uma empresa.", 500);
        }
        #endregion

        #region Remove Company
        try
        {
            await _repository.DeleteCompany(company, cancellationToken);
        }
        catch (Exception ex)
        {
            return new Response(ex.Message, 400);
        }
        #endregion

        #region Response
        return new Response("Empresa removida com sucesso.", new ResponseData(request.Id));
        #endregion
    }
}
