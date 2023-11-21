using FluentValidation;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.SearchEmployeeId;

public class Specifiication : AbstractValidator<Request>
{
    public Specifiication()
    {
        RuleFor(x => x.Id).NotNull().WithMessage("O ID não pode ser nulo.");
        RuleFor(x => x.Id).NotEmpty().WithMessage("O ID não pode estar vazio.");
    }
}
