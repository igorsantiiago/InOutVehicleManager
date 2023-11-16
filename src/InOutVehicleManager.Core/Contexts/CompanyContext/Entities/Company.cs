using InOutVehicleManager.Core.Contexts.CompanyContext.ValueObjects;
using InOutVehicleManager.Core.Contexts.EmployeeContext.Entities;
using InOutVehicleManager.Core.Contexts.SharedContext.Entities;
using System.Text.Json.Serialization;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.Entities;

public class Company : Entity
{
    public Company(string name, Cnpj cnpj, Address address, Phone phone, Guid? idParking = null)
    {
        Name = name;
        Cnpj = cnpj;
        Address = address;
        Phone = phone;
        IdParking = idParking;
        Employees = new();
    }

    public string Name { get; private set; } = string.Empty;
    public Cnpj Cnpj { get; private set; }
    public Address Address { get; private set; }
    public Phone Phone { get; private set; }


    public Guid? IdParking { get; set; }
    [JsonIgnore]
    public Parking Parking { get; set; } = null!;

    public List<Employee> Employees { get; set; }

    public void UpdateName(string name)
        => Name = name;

    public void UpdateCnpj(string cnpj)
        => Cnpj.UpdateCnpj(cnpj);

    public void UpdateAddress(string zipcode, string street, int addressNumber, string addressLine, string city, string state)
    {
        Address.UpdateZipCode(zipcode);
        Address.UpdateStreet(street);
        Address.UpdateAddressNumber(addressNumber);
        Address.UpdateAddressLine(addressLine);
        Address.UpdateCity(city);
        Address.UpdateState(state);
    }

    public void UpdatePhone(string? landlinePhone = null, string? mobilePhone = null)
    {
        Phone.UpdateLandlinePhone(landlinePhone);
        Phone.UpdateMobilePhone(mobilePhone);
    }
}
