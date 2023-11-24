using FluentValidation;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.RegisterEmployee;
public class Specification : AbstractValidator<Request>
{
    public Specification()
    {
        RuleFor(x => x.CompanyCnpj).NotNull().WithMessage("O CNPJ da empresa não pode ser nulo.");
        RuleFor(x => x.CompanyCnpj).NotEmpty().WithMessage("O CNPJ da empresa não pode estar vazio.");
        RuleFor(x => x.CompanyCnpj).Length(14).WithMessage("O CNPJ da empresa deve conter 14 digitos.");

        RuleFor(x => x.EmployeeCpf).NotNull().WithMessage("O CPF do funcionário não pode ser nulo.");
        RuleFor(x => x.EmployeeCpf).NotEmpty().WithMessage("O CPF do funcionário não pode estar vazio.");
        RuleFor(x => x.EmployeeCpf).Length(11).WithMessage("O CPF do funcionário deve conter 11 digitos.");
    }
}
