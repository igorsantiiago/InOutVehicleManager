using FluentValidation;

namespace InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.UpdateVehicle;

public class Specification : AbstractValidator<Request>
{
    public Specification()
    {
        RuleFor(x => x.Id).NotNull().NotEmpty().WithMessage("ID cannot be null or empty.");
        RuleFor(x => x.Model).NotNull().NotEmpty().WithMessage("Model cannot be null or empty.");
        RuleFor(x => x.Model).Length(2, 30).WithMessage("Model must have at least 2 characters and maximum 30 characters.");
        RuleFor(x => x.Brand).NotNull().NotEmpty().WithMessage("Brand cannot be null or empty.");
        RuleFor(x => x.Brand).Length(2, 30).WithMessage("Brand must have at least 2 characters and maximum 30 characters.");
        RuleFor(x => x.Color).NotNull().NotEmpty().WithMessage("Color cannot be null or empty.");
        RuleFor(x => x.Color).Length(3, 30).WithMessage("Color must have at least 3 characters and maximum 30 characters.");
        RuleFor(x => x.LicensePlate).NotNull().NotEmpty().WithMessage("License Plate cannot be null or empty.");
        RuleFor(x => x.LicensePlate).Length(6, 20).WithMessage("License Plate must have at least 3 characters and maximum 30 characters.");
        RuleFor(x => x.Type).NotNull().NotEmpty().WithMessage("Vehicle Type cannot be null or empty.");
        RuleFor(x => x.Type).Length(3, 12).WithMessage("Vehicle Type must be Car or Motocycle");
    }
}
