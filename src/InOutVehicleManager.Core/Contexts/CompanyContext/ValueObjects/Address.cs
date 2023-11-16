using InOutVehicleManager.Core.Contexts.SharedContext.ValueObjects;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.ValueObjects;

public class Address : ValueObject
{
    public Address(string zipcode, string street, int addressNumber, string addressLine, string city, string state)
    {
        ZipCode = zipcode.Trim();
        Street = street.Trim();
        AddressNumber = addressNumber;
        AddressLine = addressLine.Trim();
        City = city.Trim();
        State = state.Trim();
    }

    public string ZipCode { get; private set; } = string.Empty;
    public string Street { get; private set; } = string.Empty;
    public int AddressNumber { get; private set; }
    public string AddressLine { get; private set; } = string.Empty;
    public string City { get; private set; } = string.Empty;
    public string State { get; private set; } = string.Empty;

    public void UpdateZipCode(string zipcode) 
        => ZipCode = zipcode.Trim();

    public void UpdateStreet(string street) 
        => Street = street.Trim();

    public void UpdateAddressNumber(int addressNumber) 
        => AddressNumber = addressNumber;

    public void UpdateAddressLine(string addressLine) 
        => AddressLine = addressLine.Trim();

    public void UpdateCity(string city) 
        => City = city.Trim();

    public void UpdateState(string state) 
        => State = state.Trim();
}
