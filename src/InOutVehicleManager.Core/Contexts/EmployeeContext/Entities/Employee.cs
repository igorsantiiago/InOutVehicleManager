using InOutVehicleManager.Core.Contexts.EmployeeContext.ValueObjects;
using InOutVehicleManager.Core.Contexts.SharedContext.Entities;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;

public class Employee : Entity
{
    protected Employee() { }

    public Employee(string firstName, string lastName, string address, Guid? idEmployer, string? password = null)
    {
        Name = new(firstName, lastName);
        Email = new(address);
        IdEmployer = idEmployer;
        Password = new(password);
    }

    public Employee(Name name, Email email, Guid? idEmployer, string? password = null)
    {
        Name = name;
        Email = email;
        IdEmployer = idEmployer;
        Password = new(password);
    }

    public Name Name { get; private set; } = null!;
    public Email Email { get; private set; } = null!;
    public Password Password { get; private set; } = null!;
    public List<Role> Roles { get; private set; } = new();
    public Guid? IdEmployer{ get; private set; }

    public void UpdateName(string firstName, string lastName)
    {
        Name.UpdateFirstName(firstName);
        Name.UpdateLastName(lastName);
    }

    public void UpdateEmail(string address) => Email.UpdateEmailAddress(address);
    public void AddRole(Role role) => Roles.Add(role);
    public void RemoveRole(Role role) => Roles.Remove(role);
    public void UpdateIdEmployer(Guid? idEmployer) => IdEmployer = idEmployer;
}
