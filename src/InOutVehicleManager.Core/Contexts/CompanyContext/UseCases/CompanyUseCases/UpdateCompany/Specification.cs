using FluentValidation;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany;

public class Specification : AbstractValidator<Request>
{
    public Specification()
    {
        RuleFor(x => x.Id).NotNull().WithMessage("O ID não pode ser nulo.");
        RuleFor(x => x.Id).NotEmpty().WithMessage("O ID não pode estar vazio.");

        RuleFor(x => x.Name).NotNull().WithMessage("O campo Nome não pode ser nulo.");
        RuleFor(x => x.Name).NotEmpty().WithMessage("O campo Nome não pode estar vazio.");
        RuleFor(x => x.Name).Length(3, 40).WithMessage("O campo Nome deve conter entre 3 e 40 caracteres.");

        RuleFor(x => x.Cnpj).NotNull().WithMessage("O campo CNPJ não pode ser nulo.");
        RuleFor(x => x.Cnpj).NotEmpty().WithMessage("O campo CNPJ não pode estar vazio.");
        RuleFor(x => x.Cnpj).Length(14).WithMessage("O campo CNPJ deve conter 14 caracteres.");

        RuleFor(x => x.Zipcode).NotNull().WithMessage("O campo CEP não pode ser nulo.");
        RuleFor(x => x.Zipcode).NotEmpty().WithMessage("O campo CEP não pode estar vazio.");
        RuleFor(x => x.Zipcode).Length(8).WithMessage("O campo CEP deve conter 8 caracteres.");

        RuleFor(x => x.Street).NotNull().WithMessage("O campo Rua não pode ser nulo.");
        RuleFor(x => x.Street).NotEmpty().WithMessage("O campo Rua não pode estar vazio.");
        RuleFor(x => x.Street).Length(6, 80).WithMessage("O campo Rua deve conter entre 6 e 80 caracteres.");

        RuleFor(x => x.AddressNumber).NotNull().WithMessage("O campo Número não pode ser nulo.");
        RuleFor(x => x.AddressNumber).NotEmpty().WithMessage("O campo Número não pode estar vazio.");

        RuleFor(x => x.AddressLine).NotNull().WithMessage("O campo Complementos não pode ser nulo.");
        RuleFor(x => x.AddressLine).NotEmpty().WithMessage("O campo Complementos não podde estar vazio.");
        RuleFor(x => x.AddressLine).Length(3, 40).WithMessage("O campo Complementos deve conter entre 3 e 40 caracteres.");

        RuleFor(x => x.City).NotNull().WithMessage("O campo Cidade não pode ser nulo.");
        RuleFor(x => x.City).NotEmpty().WithMessage("O campo Cidade não pode estar vazio.");
        RuleFor(x => x.City).Length(3, 20).WithMessage("O campo Cidade deve conter entre 3 e 20 caracteres.");

        RuleFor(x => x.State).NotNull().WithMessage("o campo Estado não pode ser nulo.");
        RuleFor(x => x.State).NotEmpty().WithMessage("O campo Estado não podde estar vazio.");
        RuleFor(x => x.State).Length(4, 15).WithMessage("O campo Estado deve conter entre 4 e 15 caracteres.");

        RuleFor(x => x.LandlinePhone).MaximumLength(15).WithMessage("O campo Telefone Fixo precisa conter no máximo 15 caracteres.");
        RuleFor(x => x.MobilePhone).MaximumLength(15).WithMessage("O campo Telefone Móvel precisa conter no máximo 15 caracteres.");
    }
}
