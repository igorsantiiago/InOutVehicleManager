using FluentValidation;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee;

public class Specification : AbstractValidator<Request>
{
    public Specification()
    {
        RuleFor(x => x.Email).NotNull().WithMessage("O Email não pode ser nulo.");
        RuleFor(x => x.Email).NotEmpty().WithMessage("O Email não pode estar vazio.");
        RuleFor(x => x.Email).Length(6, 120).WithMessage("O Email precisa de pelo menos 6 caracteres e no máximo 120 caracteres.");
        RuleFor(x => x.Email).EmailAddress().WithMessage("Email Inválido.");
        RuleFor(x => x.Password).MaximumLength(128).WithMessage("A senha pode ter no máximo 128 caracteres.");
    }
}
