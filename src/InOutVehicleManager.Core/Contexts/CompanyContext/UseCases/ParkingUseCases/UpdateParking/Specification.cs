using FluentValidation;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.UpdateParking;

public class Specification : AbstractValidator<Request>
{
    public Specification()
    {
        RuleFor(x => x.Id).NotEmpty().WithMessage("O Id não pode estar vazio.");
    }
}
