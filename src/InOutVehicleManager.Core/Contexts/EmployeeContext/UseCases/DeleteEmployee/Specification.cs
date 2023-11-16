using FluentValidation;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.DeleteEmployee;

public class Specification : AbstractValidator<Request>
{
    public Specification()
    {
        RuleFor(x => x.Id).NotNull().WithMessage("O Id não pode ser nulo.");
        RuleFor(x => x.Id).NotEmpty().WithMessage("O Id não pode estar vazio.");
    }
}
