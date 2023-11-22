using FluentValidation;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.RemoveRole;

public class Specification : AbstractValidator<Request>
{
    public Specification()
    {
        RuleFor(x => x.EmployeeId).NotNull().WithMessage("O ID do funcionário não pode ser nulo.");
        RuleFor(x => x.EmployeeId).NotEmpty().WithMessage("O ID do funcionário não pode estar vazio.");
        RuleFor(x => x.Role).NotNull().WithMessage("O cargo do perfil não pode ser nulo.");
        RuleFor(x => x.Role).NotEmpty().WithMessage("O cargo do perfil não pode estar vazio.");
        RuleFor(x => x.Role).MinimumLength(3).WithMessage("O cargo do perfil não pode ser menor que 3 caracteres.");
        RuleFor(x => x.Role).MaximumLength(20).WithMessage("O cargo do perfil não pode ser maior que 20 caracteres.");
    }
}
