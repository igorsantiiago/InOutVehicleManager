using FluentValidation.Results;
using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Contracts;
using MediatR;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.CreateEmployee;

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

        #region Check if email already exists
        try
        {
            var exists = await _repository.AnyAsync(request.EmailAddress, cancellationToken);
            if (exists)
                return new Response("Erro: Email já cadastrado.", 400);
        }
        catch
        {
            return new Response("Erro: Falha ao verificar email.", 500);
        }
        #endregion

        #region Create new employee
        Employee? employee;
        try
        {
            employee = CreateEmployee(request);
            if (employee == null)
                return new Response("Erro: Falha no cadastro do funcionário.", 400);

            await _repository.SaveAsync(employee, cancellationToken);
        }
        catch (Exception ex)
        {
            return new Response(ex.Message, 400);
        }
        #endregion

        #region Response
        return new Response("Funcionário cadastrado com sucesso.",
            new ResponseData(employee.Id, employee.Name.ToString(), employee.Email.Address));
        #endregion
    }

    private static Employee? CreateEmployee(Request request)
    {
        Employee? employee = new(request.FirstName, request.LastName, request.EmailAddress, request.Password);
        if (employee == null)
            return null;

        return employee;
    }
}
