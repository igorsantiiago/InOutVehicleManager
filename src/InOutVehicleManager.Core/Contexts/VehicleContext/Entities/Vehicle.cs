using InOutVehicleManager.Core.Contexts.SharedContext.Entities;
using InOutVehicleManager.Core.Contexts.VehicleContext.Enums;

namespace InOutVehicleManager.Core.Contexts.VehicleContext.Entities;

public class Vehicle : Entity
{
    protected Vehicle() { }
    public Vehicle(string model, string brand, string color, string licensePlate, VehicleType type)
    {
        Model = model;
        Brand = brand;
        Color = color;
        LicensePlate = licensePlate;
        Type = type;
    }

    public string Model { get; private set; } = string.Empty;
    public string Brand { get; private set; } = string.Empty;
    public string Color { get; private set; } = string.Empty;
    public string LicensePlate { get; private set; } = string.Empty;
    public VehicleType Type { get; private set; }

    public void UpdateModel(string model) => Model = model;
    public void UpdateBrand(string brand) => Brand = brand;
    public void UpdateColor(string color) => Color = color;
    public void UpdateLicensePlate(string licensePlate) => LicensePlate = licensePlate;
    public void UpdateVehicleType(VehicleType type) => Type = type;
}
