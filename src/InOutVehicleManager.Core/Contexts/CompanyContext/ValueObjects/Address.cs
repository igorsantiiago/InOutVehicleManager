using InOutVehicleManager.Core.Contexts.SharedContext.ValueObjects;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.ValueObjects;

public class Address : ValueObject
{
    protected Address()
    {

    }
    public Address(string zipcode, string street, int addressNumber, string addressLine, string city, string state)
    {
        ZipCode = zipcode;
        Street = street;
        AddressNumber = addressNumber;
        AddressLine = addressLine;
        City = city;
        State = state;
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
