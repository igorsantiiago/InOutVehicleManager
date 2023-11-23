using FluentValidation;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.CreateEmployee;

public class Specification : AbstractValidator<Request>
{
    public Specification()
    {
        RuleFor(x => x.FirstName).NotNull().WithMessage("O nome não pode ser nulo.");
        RuleFor(x => x.FirstName).NotEmpty().WithMessage("O nome não pode estar vazio.");
        RuleFor(x => x.FirstName).Length(3, 30).WithMessage("O nome precisa ter pelo menos 3 caracteres e no máximo 30 caracteres.");

        RuleFor(x => x.LastName).NotNull().WithMessage("O sobrenome não pode ser nulo.");
        RuleFor(x => x.LastName).NotEmpty().WithMessage("O sobrenome não pode estar vazio.");
        RuleFor(x => x.LastName).Length(3, 30).WithMessage("O sobrenome precisa ter pelo menos 3 caracteres e no máximo 30 caracteres.");

        RuleFor(x => x.Cpf).NotNull().WithMessage("O documento de identificação (CPF) não pode ser nulo.");
        RuleFor(x => x.Cpf).NotEmpty().WithMessage("O documento de identificação (CPF) não pode estar vazio.");
        RuleFor(x => x.Cpf).Length(11).WithMessage("O documento de identificação (CPF) precisa conter 11 digitos.");

        RuleFor(x => x.EmailAddress).NotNull().WithMessage("O Email não pode ser nulo.");
        RuleFor(x => x.EmailAddress).NotEmpty().WithMessage("O Email não pode estar vazio.");
        RuleFor(x => x.EmailAddress).Length(6, 120).WithMessage("O Email precisa ter pelo menos 6 caracteres e no máximo 120 caracteres.");
        RuleFor(x => x.EmailAddress).EmailAddress().WithMessage("Email Inválido.");

        RuleFor(x => x.Password).MaximumLength(128).WithMessage("A senha precisa ter no máximo 128 caracteres.");
    }
}
