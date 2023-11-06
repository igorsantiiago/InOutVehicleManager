using FluentValidation;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee;

public class Specification : AbstractValidator<Request>
{
    public Specification()
    {
        RuleFor(x => x.Email).NotNull().NotEmpty().WithMessage("Email cannot be null or empty.");
        RuleFor(x => x.Email).EmailAddress().WithMessage("Invalid Email");
        RuleFor(x => x.Password).NotNull().NotEmpty().WithMessage("Password cannot be null or empty.");
    }
}
