using FluentValidation;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.DeleteCompany;

public class Specification : AbstractValidator<Request>
{
    public Specification()
    {
        RuleFor(x => x.Id).NotNull().WithMessage("O campo ID não pode ser nulo.");
        RuleFor(x => x.Id).NotEmpty().WithMessage("O campo ID não pode estar vazio.");
    }
}
