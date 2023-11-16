using FluentValidation;

namespace InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.CreateVehicle;

public class Specification : AbstractValidator<Request>
{
    public Specification()
    {
        RuleFor(x => x.Model).NotNull().WithMessage("O modelo do veículo não pode ser nulo.");
        RuleFor(x => x.Model).NotEmpty().WithMessage("O modelo do veículo não pode estar vazio.");
        RuleFor(x => x.Model).Length(2, 30).WithMessage("O modelo do veículo precisa de pelo menos 2 caracteres e no máximo 30 caracteres.");
        RuleFor(x => x.Brand).NotNull().WithMessage("A marca do veículo não pode ser nula.");
        RuleFor(x => x.Brand).NotEmpty().WithMessage("A marca do veículo não pode estar vazia.");
        RuleFor(x => x.Brand).Length(2, 30).WithMessage("A marca do veículo precisa de pelo menos 2 caracteres e no máximo 30 caracteres.");
        RuleFor(x => x.Color).NotNull().WithMessage("A cor do veículo não pode ser nula.");
        RuleFor(x => x.Color).NotEmpty().WithMessage("A cor do veículo não pode estar vazia.");
        RuleFor(x => x.Color).Length(3, 20).WithMessage("A cor do veículo precisa de pelo menos 3 caracteres e no máximo 20 caracteres.");
        RuleFor(x => x.LicensePlate).NotNull().WithMessage("A placa do veículo não pode ser nula.");
        RuleFor(x => x.LicensePlate).NotEmpty().WithMessage("A placa do veículo não pode estar vazia.");
        RuleFor(x => x.LicensePlate).Length(6, 12).WithMessage("A placa do veículo precisa de pelo menos 6 caracteres e no máximo 12 caracteres.");
        RuleFor(x => x.Type).NotNull().NotEmpty().WithMessage("O categoria do veículo não pode ser nula.");
        RuleFor(x => x.Type).NotEmpty().WithMessage("O categoria do veículo não pode estar vazia.");
        RuleFor(x => x.Type).Length(3, 12).WithMessage("Categoria de veículo inválido.");
    }
}
