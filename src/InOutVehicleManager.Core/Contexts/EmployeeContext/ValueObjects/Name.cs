using InOutVehicleManager.Core.Contexts.SharedContext.ValueObjects;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.ValueObjects;

public class Name : ValueObject
{
    public Name(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;

    public void UpdateFirstName(string firstName) => FirstName = firstName;
    public void UpdateLastName(string lastName) => LastName = lastName;
    public override string ToString() => FirstName + " " + LastName;
}
