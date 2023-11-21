namespace InOutVehicleManager.Tests.Contexts.CompanyContext.UseCases.CompanyUseCases;

public class Requests
{
    #region Requests

    #region Guid
    protected static readonly Guid _GuidAlreadyExists = new("4f1c7b8d-8b7c-4e3a-9cbb-3ca3a2e4a2db");
    protected static readonly Guid _GuidNew = Guid.NewGuid();
    #endregion

    #region Name
    protected static readonly string _NameNull = null!;
    protected static readonly string _NameEmpty = "";
    protected static readonly string _NameShort = "S";
    protected static readonly string _NameLarge = "CompanyWith NameToLarge ForThisRequest Test";
    protected static readonly string _Name = "Spotify";
    #endregion

    #region CNPJ
    protected static readonly string _CnpjNull = null!;
    protected static readonly string _CnpjEmpty = "";
    protected static readonly string _CnpjShort = "012345";
    protected static readonly string _CnpjLarge = "012345678901234";
    protected static readonly string _CnpjNew = "02392443070001";
    protected static readonly string _CnpjAlreadyExists = "01230123450001";
    #endregion

    #region ZipCode
    protected static readonly string _ZipCodeNull = null!;
    protected static readonly string _ZipCodeEmpty = "";
    protected static readonly string _ZipCodeShort = "2345";
    protected static readonly string _ZipCodeLarge = "987654321";
    protected static readonly string _ZipCode = "34567890";
    #endregion

    #region Address Number
    protected static readonly int _AddressNumber = 1234;
    #endregion

    #region Street
    protected static readonly string _StreetNull = null!;
    protected static readonly string _StreetEmpty = "";
    protected static readonly string _StreetShort = "Aba";
    protected static readonly string _StreetLarge = "Adelaide Street West Adelaide Street West Adelaide Street West Adelaide Street West";
    protected static readonly string _Street = "Adelaide Street West";
    #endregion

    #region Address Line
    protected static readonly string _AddressLineNull = null!;
    protected static readonly string _AddressLineEmpty = "";
    protected static readonly string _AddressLineShort = "Ad";
    protected static readonly string _AddressLineLarge = "Adelphi Building 4 Savoy Place WC2N 6AT WC2N";
    protected static readonly string _AddressLine = "Adelphi Building 4 Savoy Place WC2N 6AT";
    #endregion

    #region City
    protected static readonly string _CityNull = null!;
    protected static readonly string _CityEmpty = "";
    protected static readonly string _CityShort = "Ci";
    protected static readonly string _CityLarge = "LondonCity LargeRequest";
    protected static readonly string _City = "London";
    #endregion

    #region State
    protected static readonly string _StateNull = null!;
    protected static readonly string _StateEmpty = "";
    protected static readonly string _StateShort = "Est";
    protected static readonly string _StateLarge = "Estado Large Request";
    protected static readonly string _State = "Estado";
    #endregion

    #region Landline Phone
    protected static readonly string _LandlinePhoneLarge = "0123456789012345";
    protected static readonly string _LandlinePhone = "01234567";
    #endregion

    #region Mobile Phone
    protected static readonly string _MobilePhoneLarge = "0123456789012345";
    protected static readonly string _MobilePhone = "098765432";
    #endregion

    #endregion

    public class CreateCompany
    {
        #region Invalid Name
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidNameIsNull = new(_NameNull, _CnpjNew, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidNameIsEmpty = new(_NameEmpty, _CnpjNew, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidNameTooShort = new(_NameShort, _CnpjNew, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidNameTooLarge = new(_NameLarge, _CnpjNew, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);
        #endregion

        #region Invalid Cnpj
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidCnpjIsNull = new(_Name, _CnpjNull, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidCnpjIsEmpty = new(_Name, _CnpjEmpty, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidCnpjTooShort = new(_Name, _CnpjShort, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidCnpjTooLarge = new(_Name, _CnpjLarge, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);
        #endregion

        #region Invalid Zipcode
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidZipCodeIsNull = new(_Name, _CnpjNew, _ZipCodeNull, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidZipCodeIsEmpty = new(_Name, _CnpjNew, _ZipCodeEmpty, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidZipCodeTooShort = new(_Name, _CnpjNew, _ZipCodeShort, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidZipCodeTooLarge = new(_Name, _CnpjNew, _ZipCodeLarge, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);
        #endregion

        #region Invalid Street
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidStreetIsNull = new(_Name, _CnpjNew, _ZipCode, _StreetNull, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidStreetIsEmpty = new(_Name, _CnpjNew, _ZipCode, _StreetEmpty, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidStreetTooShort = new(_Name, _CnpjNew, _ZipCode, _StreetShort, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidStreetTooLarge = new(_Name, _CnpjNew, _ZipCode, _StreetLarge, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);
        #endregion

        #region Invalid Address Line
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidAddressLineIsNull = new(_Name, _CnpjNew, _ZipCode, _Street, _AddressNumber, _AddressLineNull, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidAddressLineIsEmpty = new(_Name, _CnpjNew, _ZipCode, _Street, _AddressNumber, _AddressLineEmpty, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidAddressLineTooShort = new(_Name, _CnpjNew, _ZipCode, _Street, _AddressNumber, _AddressLineShort, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidAddressLineTooLarge = new(_Name, _CnpjNew, _ZipCode, _Street, _AddressNumber, _AddressLineLarge, _City, _State, _LandlinePhone, _MobilePhone);
        #endregion

        #region Invalid City
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidCityIsNull = new(_Name, _CnpjNew, _ZipCode, _Street, _AddressNumber, _AddressLine, _CityNull, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidCityIsEmpty = new(_Name, _CnpjNew, _ZipCode, _Street, _AddressNumber, _AddressLine, _CityEmpty, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidCityTooShort = new(_Name, _CnpjNew, _ZipCode, _Street, _AddressNumber, _AddressLine, _CityShort, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidCityTooLarge = new(_Name, _CnpjNew, _ZipCode, _Street, _AddressNumber, _AddressLine, _CityLarge, _State, _LandlinePhone, _MobilePhone);
        #endregion

        #region Invalid State
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidStateIsNull = new(_Name, _CnpjNew, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _StateNull, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidStateIsEmpty = new(_Name, _CnpjNew, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _StateEmpty, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidStateTooShort = new(_Name, _CnpjNew, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _StateShort, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidStateTooLarge = new(_Name, _CnpjNew, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _StateLarge, _LandlinePhone, _MobilePhone);
        #endregion

        #region Invalid Landline Phone
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidLandlinePhoneTooLarge = new(_Name, _CnpjNew, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhoneLarge, _MobilePhone);
        #endregion

        #region Invalid Mobile Phone
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidMobilePhoneTooLarge = new(_Name, _CnpjNew, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhoneLarge);
        #endregion

        #region Invalid Already Exists
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            invalidCompanyAlreadyExists = new(_Name, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);
        #endregion

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request
            validRequest = new(_Name, _CnpjNew, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);
    }

    public class UpdateCompany
    {
        #region Invalid Name
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidNameIsNull = new(_GuidAlreadyExists, _NameNull, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidNameIsEmpty = new(_GuidAlreadyExists, _NameEmpty, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidNameTooShort = new(_GuidAlreadyExists, _NameShort, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidNameTooLarge = new(_GuidAlreadyExists, _NameLarge, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);
        #endregion

        #region Invalid Cnpj
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidCnpjIsNull = new(_GuidAlreadyExists, _Name, _CnpjNull, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidCnpjIsEmpty = new(_GuidAlreadyExists, _Name, _CnpjEmpty, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidCnpjTooShort = new(_GuidAlreadyExists, _Name, _CnpjShort, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidCnpjTooLarge = new(_GuidAlreadyExists, _Name, _CnpjLarge, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);
        #endregion

        #region Invalid Zipcode
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidZipcodeIsNull = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCodeNull, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidZipcodeIsEmpty = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCodeEmpty, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidZipcodeTooShort = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCodeShort, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidZipcodeTooLarge = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCodeLarge, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);
        #endregion

        #region Invalid Street
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidStreetIsNull = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCode, _StreetNull, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidStreetIsEmpty = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCode, _StreetEmpty, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidStreetTooShort = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCode, _StreetShort, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidStreetTooLarge = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCode, _StreetLarge, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);
        #endregion

        #region Invalid Address Line
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidAddressLineIsNull = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLineNull, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidAddressLineIsEmpty = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLineEmpty, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidAddressLineTooShort = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLineShort, _City, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidAddressLineTooLarge = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLineLarge, _City, _State, _LandlinePhone, _MobilePhone);
        #endregion

        #region Invalid City
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidCityIsNull = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLine, _CityNull, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidCityIsEmpty = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLine, _CityEmpty, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidCityTooShort = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLine, _CityShort, _State, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidCityTooLarge = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLine, _CityLarge, _State, _LandlinePhone, _MobilePhone);
        #endregion

        #region Invalid State
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidStateIsNull = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _StateNull, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidStateIsEmpty = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _StateEmpty, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidStateTooShort = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _StateShort, _LandlinePhone, _MobilePhone);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidStateTooLarge = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _StateLarge, _LandlinePhone, _MobilePhone);
        #endregion

        #region Invalid Landline Phone
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidLandlinePhoneTooLarge = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhoneLarge, _MobilePhone);
        #endregion

        #region Invalid Mobile Phone
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidMobilePhoneTooLarge = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhoneLarge);
        #endregion

        #region Invalid Company Not Found
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            invalidCompanyNotFound = new(_GuidNew, _Name, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);
        #endregion

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request
            validRequest = new(_GuidAlreadyExists, _Name, _CnpjAlreadyExists, _ZipCode, _Street, _AddressNumber, _AddressLine, _City, _State, _LandlinePhone, _MobilePhone);
    }

    public class DeleteCompany
    {
        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.DeleteCompany.Request
            _invalidCompanyNotFound = new(_GuidNew);

        public readonly Core.Contexts.CompanyContext.UseCases.CompanyUseCases.DeleteCompany.Request
            _validRequest = new(_GuidAlreadyExists);

    }
}
