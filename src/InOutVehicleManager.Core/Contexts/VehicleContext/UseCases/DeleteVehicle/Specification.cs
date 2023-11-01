using FluentValidation;

namespace InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.DeleteVehicle;

public class Specification : AbstractValidator<Request>
{
    public Specification()
    {
        RuleFor(x => x.Id).NotNull().NotEmpty().WithMessage("ID cannot be null or empty.");
    }
}
