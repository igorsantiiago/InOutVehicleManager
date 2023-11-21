using InOutVehicleManager.Core.Contexts.SharedContext.Entities;
using InOutVehicleManager.Core.Contexts.VehicleContext.Enums;
using System.Text.Json.Serialization;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.Entities;

public class Parking : Entity
{
    public Parking(int totalCarParkingSpaces, int totalMotorcycleParkingSpaces)
    {
        TotalCarParkingSpaces = totalCarParkingSpaces;
        TotalMotorcycleParkingSpaces = totalMotorcycleParkingSpaces;

        AvailableCarParkingSpaces = TotalCarParkingSpaces;
        AvailableMotorcycleParkingSpaces = TotalMotorcycleParkingSpaces;
    }

    public int TotalCarParkingSpaces { get; private set; }
    public int TotalMotorcycleParkingSpaces { get; private set; }
    public int AvailableCarParkingSpaces { get; private set; }
    public int AvailableMotorcycleParkingSpaces { get; private set; }

    [JsonIgnore]
    public List<Company> Companies { get; set; } = null!;

    public void UpddateTotalCarSpaces(int totalCarSpaces)
    {
        var spaceUsage = TotalCarParkingSpaces - AvailableCarParkingSpaces;
        TotalCarParkingSpaces = totalCarSpaces;
        // AvailableCarParkingSpaces = totalCarSpaces - spaceUsage;
        AvailableCarParkingSpaces = Math.Max(0, totalCarSpaces - spaceUsage);
    }

    public void UpdateTotalMotorcycleSpaces(int totalMotorcycleSpaces)
    {
        var spaceUsage = TotalMotorcycleParkingSpaces - AvailableMotorcycleParkingSpaces;
        TotalMotorcycleParkingSpaces = totalMotorcycleSpaces;
        // AvailableMotorcycleParkingSpaces = totalMotorcycleSpaces - spaceUsage;
        AvailableMotorcycleParkingSpaces = Math.Max(0, totalMotorcycleSpaces - spaceUsage);
    }

    public void VehicleIn(VehicleType type)
    {
        if (type == VehicleType.Car)
            AvailableCarParkingSpaces--;
        else
            AvailableMotorcycleParkingSpaces--;
    }

    public void VehicleOut(VehicleType type)
    {
        if (type == VehicleType.Car)
            AvailableCarParkingSpaces++;
        else
            AvailableMotorcycleParkingSpaces++;
    }
}
