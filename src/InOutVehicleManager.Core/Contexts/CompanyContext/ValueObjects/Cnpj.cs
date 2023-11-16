using InOutVehicleManager.Core.Contexts.SharedContext.ValueObjects;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.ValueObjects;

public class Cnpj : ValueObject
{
    public Cnpj(string cpnj) => Document = cpnj;

    public string Document { get; private set; } = string.Empty;

    public void UpdateCnpj(string cnpj)
        => Document = cnpj;

    public override string ToString() => Document;
}
