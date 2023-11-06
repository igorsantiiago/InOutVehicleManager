using InOutVehicleManager.Core.Contexts.SharedContext.Entities;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;

public class Role : Entity
{
    protected Role() { }

    public Role(string name) => Name = name;

    public string Name { get; private set; } = string.Empty;

    public void UpdateName(string name) => Name = name;

}
