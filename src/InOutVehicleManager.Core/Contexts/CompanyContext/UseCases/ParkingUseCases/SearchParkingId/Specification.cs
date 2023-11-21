using FluentValidation;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.SearchParkingId;

public class Specification : AbstractValidator<Request>
{
    public Specification()
    {
        RuleFor(x => x.Id).NotNull().WithMessage("O ID não pode ser nulo.");
        RuleFor(x => x.Id).NotEmpty().WithMessage("O ID não pode estar vazio.");
    }
}
