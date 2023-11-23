using InOutVehicleManager.Core.Contexts.SharedContext.ValueObjects;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.ValueObjects;

public class Document : ValueObject
{
    public Document(string cpf)
    {
        Cpf = cpf;
    }

    public string Cpf { get; set; }

    public void UpdateCpf(string cpf) => Cpf = cpf;
    public override string ToString() => Cpf;
}
