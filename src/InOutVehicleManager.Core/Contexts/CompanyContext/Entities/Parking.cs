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

    public Guid? IdCompany { get; set; }
    [JsonIgnore]
    public Company Company { get; set; } = null!;

    public void UpddateTotalCarSpaces(int totalCarSpaces)
    {
        var spaceUsage = totalCarSpaces - (TotalCarParkingSpaces - AvailableCarParkingSpaces);
        TotalCarParkingSpaces = totalCarSpaces;
        AvailableCarParkingSpaces = totalCarSpaces - spaceUsage;
    }

    public void UpdateTotalMotorcycleSpaces(int totalMotorcycleSpaces)
    {
        var spaceUsage = totalMotorcycleSpaces - (TotalMotorcycleParkingSpaces - AvailableMotorcycleParkingSpaces);
        TotalMotorcycleParkingSpaces = totalMotorcycleSpaces;
        AvailableMotorcycleParkingSpaces = totalMotorcycleSpaces - spaceUsage;
    }

    public void UpdateIdCompany(Guid? idCompany)
        => IdCompany = idCompany;
        

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
    