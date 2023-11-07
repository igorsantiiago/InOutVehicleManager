namespace InOutVehicleManager.Tests.Contexts.VehicleContext.UseCases;

public class Requests
{
    #region Parameters
    protected static readonly Guid _GuidRegistered = new("4f1c7b8d-8b7c-4e3a-9cbb-3ca3a2e4a2db");
    protected static readonly Guid _NewGuid = new("3F2504E0-4F89-11D3-9A0C-0305E82C3301");

    protected static readonly string _ModelNull = null!;
    protected static readonly string _ModelShort  = "C";
    protected static readonly string _ModelLarge = "CarWithNameTooLargeForThisRequest";
    protected static readonly string _Model = "Cayenne";

    protected static readonly string _BrandNull = null!;
    protected static readonly string _BrandShort = "P";
    protected static readonly string _BrandLarge = "BrandWithNameTooLargeForThisRequest";
    protected static readonly string _Brand = "Porsche";

    protected static readonly string _ColorNull = null!;
    protected static readonly string _ColorShort = "Y";
    protected static readonly string _ColorLarge = "YellowColorWithOtherColors";
    protected static readonly string _Color = "Yellow";

    protected static readonly string _LicensePlateNull = null!;
    protected static readonly string _LicensePlateShort = "A1B2";
    protected static readonly string _LicensePlateLarge = "A1B2C3D4E5Z1X2";
    protected static readonly string _LicensePlateAlreadyExists = "X1Y2Z3W4";
    protected static readonly string _LicensePlate = "A1B2C3D4";

    protected static readonly string _TypeNull = null!;
    protected static readonly string _TypeInvalid = "CarrTypo";
    protected static readonly string _TypeCar = "Car";
    protected static readonly string _TypeMotorcycle = "Motorcycle";
    #endregion

    public class CreateRequests
    {
        public readonly Core.Contexts.VehicleContext.UseCases.CreateVehicle.Request 
            invalidModelNullOrEmpty = new(_ModelNull, _Brand, _Color, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.CreateVehicle.Request 
            invalidModelTooShort = new(_ModelShort, _Brand, _Color, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.CreateVehicle.Request 
            invalidModelTooLarge = new(_ModelLarge, _Brand, _Color, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.CreateVehicle.Request 
            invalidBrandNullOrEmpty = new(_Model, _BrandNull, _Color, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.CreateVehicle.Request 
            invalidBrandTooShort = new(_Model, _BrandShort, _Color, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.CreateVehicle.Request 
            invalidBrandTooLarge = new(_Model, _BrandLarge, _Color, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.CreateVehicle.Request 
            invalidColorNullOrEmpty = new(_Model, _Brand, _ColorNull, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.CreateVehicle.Request 
            invalidColorTooShort = new(_Model, _Brand, _ColorShort, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.CreateVehicle.Request 
            invalidColorTooLarge = new(_Model, _Brand, _ColorLarge, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.CreateVehicle.Request 
            invalidLicensePlateNullOrEmpty = new(_Model, _Brand, _Color, _LicensePlateNull, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.CreateVehicle.Request 
            invalidLicensePlateTooShort = new(_Model, _Brand, _Color, _LicensePlateShort, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.CreateVehicle.Request 
            invalidLicensePlateTooLarge = new(_Model, _Brand, _Color, _LicensePlateLarge, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.CreateVehicle.Request 
            invalidTypeNullOrEmpty = new(_Model, _Brand, _Color, _LicensePlate, _TypeNull);

        public readonly Core.Contexts.VehicleContext.UseCases.CreateVehicle.Request 
            invalidTypeNotExists = new(_Model, _Brand, _Color, _LicensePlate, _TypeInvalid);

        public readonly Core.Contexts.VehicleContext.UseCases.CreateVehicle.Request 
            invalidLicensePlateAlreadyExists = new(_Model, _Brand, _Color, _LicensePlateAlreadyExists, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.CreateVehicle.Request 
            validLicensePlateNew = new(_Model, _Brand, _Color, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.CreateVehicle.Request 
            validRequest = new(_Model, _Brand, _Color, _LicensePlate, _TypeCar);
    }

    public class UpdateRequests
    {
        public readonly Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Request 
            invalidModelNullOrEmpty = new(_GuidRegistered, _ModelNull, _Brand, _Color, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Request 
            invalidModelTooShort = new(_GuidRegistered, _ModelShort, _Brand, _Color, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Request 
            invalidModelTooLarge = new(_GuidRegistered, _ModelLarge, _Brand, _Color, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Request 
            invalidBrandNullOrEmpty = new(_GuidRegistered, _Model, _BrandNull, _Color, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Request 
            invalidBrandTooShort = new(_GuidRegistered, _Model, _BrandShort, _Color, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Request 
            invalidBrandTooLarge = new(_GuidRegistered, _Model, _BrandLarge, _Color, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Request 
            invalidColorNullOrEmpty = new(_GuidRegistered, _Model, _Brand, _ColorNull, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Request 
            invalidColorTooShort = new(_GuidRegistered, _Model, _Brand, _ColorShort, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Request 
            invalidColorTooLarge = new(_GuidRegistered, _Model, _Brand, _ColorLarge, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Request 
            invalidLicensePlateNullOrEmpty = new(_GuidRegistered, _Model, _Brand, _Color, _LicensePlateNull, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Request 
            invalidLicensePlateTooShort = new(_GuidRegistered, _Model, _Brand, _Color, _LicensePlateShort, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Request 
            invalidLicensePlateTooLarge = new(_GuidRegistered, _Model, _Brand, _Color, _LicensePlateLarge, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Request 
            invalidTypeNullOrEmpty = new(_GuidRegistered, _Model, _Brand, _Color, _LicensePlate, _TypeNull);

        public readonly Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Request 
            invalidTypeNotExists = new(_GuidRegistered, _Model, _Brand, _Color, _LicensePlate, _TypeInvalid);

        public readonly Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Request 
            invalidIdNotExist= new(_NewGuid, _Model, _Brand, _Color, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Request 
            validLicensePlateNew = new(_GuidRegistered, _Model, _Brand, _Color, _LicensePlate, _TypeCar);

        public readonly Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Request 
            validRequest =new(_GuidRegistered, _Model, _Brand, _Color, _LicensePlate, _TypeCar);
    }

    public class DeleteRequests
    {
        public readonly Core.Contexts.VehicleContext.UseCases.DeleteVehicle.Request 
            invalidVehicleNotFound = new(_NewGuid);

        public readonly Core.Contexts.VehicleContext.UseCases.DeleteVehicle.Request 
            validVehicleDeleted = new(_GuidRegistered);
    }
}
