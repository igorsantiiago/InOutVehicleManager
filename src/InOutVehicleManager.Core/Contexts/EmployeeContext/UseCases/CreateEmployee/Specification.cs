using FluentValidation;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.CreateEmployee;

public class Specification : AbstractValidator<Request>
{
    public Specification()
    {
        RuleFor(x => x.FirstName).NotNull().NotEmpty().WithMessage("First name cannot be null or empty.");
        RuleFor(x => x.FirstName).Length(3, 30).WithMessage("First name must have at least 3 characters and maximum 30 characters.");
        RuleFor(x => x.LastName).NotNull().NotEmpty().WithMessage("Last name cannot be null or empty.");
        RuleFor(x => x.LastName).Length(3, 30).WithMessage("Last name must have at least 3 characters and maximum 30 characters.");
        RuleFor(x => x.EmailAddress).NotNull().NotEmpty().WithMessage("Email cannot be null or empty.");
        RuleFor(x => x.EmailAddress).Length(6, 120).WithMessage("Email has to have at least 6 characters and maximum 120 characters.");
        RuleFor(x => x.EmailAddress).EmailAddress().WithMessage("Invalid Email.");
        RuleFor(x => x.Password).MaximumLength(128).WithMessage("Password max size is 128 caracters.");
    }
}
