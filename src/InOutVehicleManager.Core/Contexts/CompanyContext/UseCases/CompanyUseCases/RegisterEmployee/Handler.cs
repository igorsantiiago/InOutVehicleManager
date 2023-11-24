using FluentValidation.Results;
using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.RegisterEmployee.Contracts;
using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using MediatR;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.RegisterEmployee;

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

        #region Get Company and Employee
        Company? company;
        Employee? employee;
        try
        {
            company = await _repository.GetCompanyByCnpj(request.CompanyCnpj, cancellationToken);
            if (company is null)
                return new Response("Company not found.", 404);

            employee = await _repository.GetEmployeeByCpf(request.EmployeeCpf, cancellationToken);
            if (employee is null)
                return new Response("Employee not found.", 404);
        }
        catch (Exception ex)
        {
            return new Response($"Erro: {ex.Message}", 400);
        }
        #endregion

        #region Add Employee into a Company
        try
        {
            company.RegisterEmployee(employee);
            await _repository.SaveAsync(company, cancellationToken);
        }
        catch (Exception ex)
        {
            return new Response($"Erro: Falha ao registrar funcionário a uma empresa. \n{ex.Message}", 400);
        }
        #endregion

        #region Response
        return new Response($"Funcionário {employee.Name.ToString()} registrado a empresa {company.Name}.", new ResponseData(company.Cnpj.ToString(), company.Name, employee.Document.Cpf, employee.Name.ToString()));
        #endregion
    }
}
