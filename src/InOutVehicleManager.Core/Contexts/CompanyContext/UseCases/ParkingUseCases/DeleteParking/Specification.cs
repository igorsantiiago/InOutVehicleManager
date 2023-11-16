using FluentValidation;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.DeleteParking;

public class Specification : AbstractValidator<Request>
{
    public Specification()
    {
        RuleFor(x => x.Id).NotEmpty().WithMessage("O ID não pode ser vazio.");
    }
}
