using FluentValidation;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee;

public class Specification : AbstractValidator<Request>
{
    public Specification()
    {
        RuleFor(x => x.Email).NotNull().NotEmpty().WithMessage("Email cannot be null or empty.");
        RuleFor(x => x.Email).Length(6, 120).WithMessage("Email has to have at least 6 characters and maximum 120 characters.");
        RuleFor(x => x.Email).EmailAddress().WithMessage("Invalid Email.");
        RuleFor(x => x.Password).MaximumLength(128).WithMessage("Password max size is 128 caracters.");
    }
}
