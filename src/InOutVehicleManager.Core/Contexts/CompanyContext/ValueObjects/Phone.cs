using InOutVehicleManager.Core.Contexts.SharedContext.ValueObjects;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.ValueObjects;

public class Phone : ValueObject
{
    public Phone(string? landlinePhone, string? mobilePhone)
    {
        LandlinePhone = landlinePhone;
        MobilePhone = mobilePhone;
    }

    public string? LandlinePhone { get; private set; } = string.Empty;
    public string? MobilePhone { get; private set; } = string.Empty;

    public void UpdateLandlinePhone(string? landlinePhone) 
        => LandlinePhone = landlinePhone;

    public void UpdateMobilePhone(string? mobilePhone) 
        => MobilePhone = mobilePhone;
}