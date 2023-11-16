namespace InOutVehicleManager.Tests.Contexts.CompanyContext.UseCases.ParkingUseCases;

public class Requests
{
    #region Parameters
    protected static readonly Guid _GuidRegistered = new("4f1c7b8d-8b7c-4e3a-9cbb-3ca3a2e4a2db");
    protected static readonly Guid _NewGuid = Guid.NewGuid();

    protected static readonly int _validCarParkingSpaces = 10;
    protected static readonly int _validMotorcycleParkingSpaces = 20;
    #endregion

    public class CreateParking
    {
        public readonly Core.Contexts.CompanyContext.UseCases.ParkingUseCases.CreateParking.Request
            validRequest = new(_validCarParkingSpaces, _validMotorcycleParkingSpaces);
    }

    public class UpdateParking
    {
        public readonly Core.Contexts.CompanyContext.UseCases.ParkingUseCases.UpdateParking.Request
            invalidParkingNotFound = new(_NewGuid, 20, 30, null);

        public readonly Core.Contexts.CompanyContext.UseCases.ParkingUseCases.UpdateParking.Request
            validParkingUpdate = new(_GuidRegistered, 20, 30, null);
    }

    public class DeleteParking
    {
        public readonly Core.Contexts.CompanyContext.UseCases.ParkingUseCases.DeleteParking.Request
            invalidParkingNotFound = new(_NewGuid);

        public readonly Core.Contexts.CompanyContext.UseCases.ParkingUseCases.DeleteParking.Request
            validParkingDeleted = new(_GuidRegistered);
    }
}
