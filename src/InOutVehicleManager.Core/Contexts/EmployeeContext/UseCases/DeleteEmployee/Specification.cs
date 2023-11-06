using FluentValidation;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.DeleteEmployee;

public class Specification : AbstractValidator<Request>
{
    public Specification()
    {
        RuleFor(x => x.Id).NotNull().NotEmpty().WithMessage("Id cannot be null or empty.");
    }
}
