using InOutVehicleManager.Core.Contexts.SharedContext.ValueObjects;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.ValueObjects;

public class Email : ValueObject
{
    public Email(string address) => Address = address;

    public string Address { get; private set; } = string.Empty;

    public override string ToString() => Address;
    public void UpdateEmailAddress(string emailAddress) => Address = emailAddress;
}
