using FluentValidation.Results;
using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Contracts;
using MediatR;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.UpdateEmployee;

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

        #region Get Employee
        Employee? employee;
        try
        {
            employee = await _repository.GetEmployeeById(request.Id, cancellationToken);
            if (employee == null)
                return new Response("Erro: Funcionário não encontrado.", 404);
        }
        catch
        {
            return new Response("Erro: Falha ao buscar o funcionário.", 500);
        }
        #endregion

        #region Check if Email exists
        try
        {
            if (request.EmailAddress != employee.Email.Address)
            {
                var exists = await _repository.AnyAsync(request.EmailAddress, cancellationToken);

                if (exists)
                    return new Response("Erro: Email já esta cadastrado.", 400);
            }
        }
        catch
        {
            return new Response("Erro: Falha ao verificar email.", 400);
        }
        #endregion

        #region Update Employee
        try
        {
            employee = UpdateEmployee(employee, request);
        }
        catch (Exception ex)
        {
            return new Response(ex.Message, 400);
        }
        #endregion

        #region Response
        return new Response("Funcionário atualizado com sucesso.", new ResponseData(employee.Id, employee.Name.ToString(), employee.Email.ToString()));
        #endregion
    }

    private static Employee UpdateEmployee(Employee employee, Request request)
    {
        employee.UpdateName(request.FirstName, request.LastName);
        employee.UpdateEmail(request.EmailAddress);

        return employee;
    }
}
