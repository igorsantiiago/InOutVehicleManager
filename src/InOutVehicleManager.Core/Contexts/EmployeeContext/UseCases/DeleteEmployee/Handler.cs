using FluentValidation.Results;
using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.DeleteEmployee.Contracts;
using MediatR;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.DeleteEmployee;

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

		#region Get Employee
		Employee? employee;
		try
		{
            employee = await _repository.GetEmployeeById(request.Id, cancellationToken);
			if (employee == null)
				return new Response("Employee not found.", 404);
		}
		catch
		{
			return new Response("Failed to retrieve employee.", 500);
		}
		#endregion

		#region Remove Employee
		try
        {
            await _repository.DeleteEmployee(employee, cancellationToken);
		}
		catch (Exception ex)
		{
			return new Response(ex.Message, 500);
		}
		#endregion

		#region Response
		return new Response("Employee removed successfully.", new ResponseData(employee.Id, employee.Name.ToString()));
		#endregion
	}
}
