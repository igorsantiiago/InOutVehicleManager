using FluentValidation.Results;
using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee.Contracts;
using MediatR;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee;

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
                return new Response("Invalid Request.", 400, result.Errors);
        }
        catch
        {
            return new Response("Unable to validate request.", 500);
        }
        #endregion

        #region Get Employee By Email
        Employee? employee;
        try
        {
            employee = await _repository.GetEmployeeByEmail(request.Email, cancellationToken);
            if (employee == null)
                return new Response("Employee not found.", 404);
        }
        catch
        {
            return new Response("Unable to retrieve employee.", 500);
        }
        #endregion

        #region Check if password is Valid
        try
        {
            if (!employee.Password.VerifyHash(request.Password))
                return new Response("Email or Password invalid.", 400);
        }
        catch (Exception ex)
        {
            return new Response(ex.Message, 400);
        }
        #endregion

        #region Response
        return new Response("", new ResponseData
        {
            Id = employee.Id.ToString(),
            Email = employee.Email.ToString(),
            Roles = employee.Roles.Select(x => x.Name).ToArray()
        });
        #endregion
    }
}
