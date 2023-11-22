using FluentValidation.Results;
using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AddRole.Contracts;
using MediatR;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AddRole;

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

        #region Get Employee and Role
        Employee? employee;
        Role? role;
        try
        {
            employee = await _repository.GetEmployeeByIdAsync(request.EmployeeId, cancellationToken);
            if (employee is null)
                return new Response("Funcionário não encontrado.", 404);

            role = await _repository.GetRoleByNameAsync(request.Role, cancellationToken);
            if (role is null)
                return new Response("Cargo de perfil não encontrado.", 404);
        }
        catch (Exception ex)
        {
            return new Response($"Erro: {ex.Message}", 400);
        }
        #endregion

        #region Add Role
        try
        {
            employee.AddRole(role);
            await _repository.SaveAsync(employee, cancellationToken);
        }
        catch (Exception ex)
        {
            return new Response($"Erro: {ex.Message}", 400);
        }
        #endregion

        #region Response
        return new Response($"Cargo de perfil {role.Name} adicionado ao perfil {employee.Name}.", new ResponseData(employee.Id, role.Name));
        #endregion
    }
}
