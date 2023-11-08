namespace InOutVehicleManager.Tests.Contexts.EmployeeContext.UseCases;

public class Requests
{
    #region Parameters
    protected static readonly Guid _GuidRegistered = new("4f1c7b8d-8b7c-4e3a-9cbb-3ca3a2e4a2db");
    protected static readonly Guid _NewGuid = Guid.NewGuid();

	protected static readonly string _FirstNameNull = null!;
	protected static readonly string _FirstNameShort = "Do";
	protected static readonly string _FirstNameLarge = "DouglasHasFirstNameBiggerRequired";
	protected static readonly string _FirstName = "Douglas";

    protected static readonly string _LastNameNull = null!;
    protected static readonly string _LastNameShort = "Ad";
    protected static readonly string _LastNameLarge = "AdamsHasLastNameBiggerRequiredTest";
    protected static readonly string _LastName = "Adams";

    protected static readonly string _EmailAddressNull = null!;
    protected static readonly string _EmailAddressShort = "d@a.c";
    protected static readonly string _EmailAddressLarge = "douglasadams42theanswertolifetheuniverseandeverything.douglasadams42theanswertolifetheuniverseandeverything.douglasadams@gmail.com";
    protected static readonly string _EmailAddressInvalid = "douglasadamscontato.com";
    protected static readonly string _EmailAddressAlreadyExists = "contato@contato.com";
    protected static readonly string _EmailAddressAlreadyExistsOtherEmployee = "emailexists@contato.com";
    protected static readonly string _EmailAddress = "douglasadams@contato.com";
    
    protected static readonly Guid? _IdEmployerNull = null!;
    protected static readonly Guid? _IdEmployer = Guid.NewGuid();

    protected static readonly string _PasswordNull = null!;
    protected static readonly string _PasswordShort = "ABC123";
    protected static readonly string _PasswordLarge = "aBcD1#2$3%4^5&6*7(8)9_0+QWERTYUIOP{}|ASDFGHJKL:ZXCVBNM?qwertyuiop[]asdfghjkl;zxcvbnm,.SN09vn98ud0S=-9HGfvdniojD0-987Nsdvm0iua-079gFBJKgopjkm";
    protected static readonly string _Password = "aBcD1#2$3%4^5&6*7(8)9_0+QWERTY";
    #endregion

    public class AuthenticateEmployee
	{

	}

	public class CreateEmployee
	{
        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidFirstNameIsNull = new(_FirstNameNull, _LastName, _EmailAddress, _IdEmployer, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidFirstNameTooShort = new(_FirstNameShort, _LastName, _EmailAddress, _IdEmployer, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidFirstNameTooLarge = new(_FirstNameLarge, _LastName, _EmailAddress, _IdEmployer, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidLastNameIsNull = new(_FirstName, _LastNameNull, _EmailAddress, _IdEmployer, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidLastNameTooShort = new(_FirstName, _LastNameShort, _EmailAddress, _IdEmployer, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidLastNameTooLarge = new(_FirstName, _LastNameLarge, _EmailAddress, _IdEmployer, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidEmailAddressIsNull = new(_FirstName, _LastName, _EmailAddressNull, _IdEmployer, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidEmailAddressTooShort = new(_FirstName, _LastName, _EmailAddressShort, _IdEmployer, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidEmailAddressTooLarge = new(_FirstName, _LastName, _EmailAddressLarge, _IdEmployer, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidEmailAddress = new(_FirstName, _LastName, _EmailAddressInvalid, _IdEmployer, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidEmailAddressAlreadyExists = new(_FirstName, _LastName, _EmailAddressAlreadyExists, _IdEmployer, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidPasswordTooLarge = new(_FirstName, _LastName, _EmailAddress, _IdEmployer, _PasswordLarge);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            validEmailAddressNew = new(_FirstName, _LastName, _EmailAddress, _IdEmployer, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            validRequest = new(_FirstName, _LastName, _EmailAddress, _IdEmployer, _Password);
    }

	public class UpdateEmployee
	{
        public readonly Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request
            invalidFirstNameIsNull = new(_GuidRegistered, _FirstNameNull, _LastName, _EmailAddress);

        public readonly Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request
            invalidFirstNameTooShort = new(_GuidRegistered, _FirstNameShort, _LastName, _EmailAddress);

        public readonly Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request
            invalidFirstNameTooLarge = new(_GuidRegistered, _FirstNameLarge, _LastName, _EmailAddress);

        public readonly Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request
            invalidLastNameIsNull = new(_GuidRegistered, _FirstName, _LastNameNull, _EmailAddress);

        public readonly Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request
            invalidLastNameTooShort = new(_GuidRegistered, _FirstName, _LastNameShort, _EmailAddress);

        public readonly Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request
            invalidLastNameTooLarge = new(_GuidRegistered, _FirstName, _LastNameLarge, _EmailAddress);

        public readonly Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request
            invalidEmailAddressIsNull = new(_GuidRegistered, _FirstName, _LastName, _EmailAddressNull);

        public readonly Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request
            invalidEmailAddressTooShort = new(_GuidRegistered, _FirstName, _LastName, _EmailAddressShort);

        public readonly Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request
            invalidEmailAddressTooLarge = new(_GuidRegistered, _FirstName, _LastName, _EmailAddressLarge);

        public readonly Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request
            invalidEmailAddress = new(_GuidRegistered, _FirstName, _LastName, _EmailAddressInvalid);

        public readonly Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request
            invalidEmailAddressAlreadyExists = new(_GuidRegistered, _FirstName, _LastName, _EmailAddressAlreadyExistsOtherEmployee);

        public readonly Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request
            validEmailAddressNewOrSameEmail = new(_GuidRegistered, _FirstName, _LastName, _EmailAddress);

        public readonly Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request
            validRequest = new(_GuidRegistered, _FirstName, _LastName, _EmailAddress);
	}

	public class DeleteEmployee
	{
        public readonly Core.Contexts.EmployeeContext.UseCases.DeleteEmployee.Request
            invalidEmployeeNotFound = new(_NewGuid);

        public readonly Core.Contexts.EmployeeContext.UseCases.DeleteEmployee.Request
            validRequest = new(_GuidRegistered);
	}
}
