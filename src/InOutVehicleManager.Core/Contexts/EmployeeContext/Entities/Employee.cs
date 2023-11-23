using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.EmployeeContext.ValueObjects;
using InOutVehicleManager.Core.Contexts.SharedContext.Entities;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;

public class Employee : Entity
{
    protected Employee() { }

    public Employee(string firstName, string lastName, string document, string emailAddress, string? password = null)
    {
        Name = new(firstName, lastName);
        Document = new(document);
        Email = new(emailAddress);
        Password = new(password);
    }

    public Employee(Name name, Document document, Email email, string? password = null)
    {
        Name = name;
        Document = document;
        Email = email;
        Password = new(password);
    }

    public Name Name { get; private set; } = null!;
    public Document Document { get; set; } = null!;
    public Email Email { get; private set; } = null!;
    public Password Password { get; private set; } = null!;
    public List<Role> Roles { get; private set; } = new();
    public List<Company> Companies { get; set; } = new();

    public void UpdateName(string firstName, string lastName)
    {
        Name.UpdateFirstName(firstName);
        Name.UpdateLastName(lastName);
    }

    public void UpdateEmail(string address) => Email.UpdateEmailAddress(address);
    public void AddRole(Role role) => Roles.Add(role);
    public void RemoveRole(Role role) => Roles.Remove(role);
}
