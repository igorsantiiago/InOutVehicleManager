namespace InOutVehicleManager.Tests.Contexts.EmployeeContext.UseCases;

public class Requests
{
    #region Parameters

    #region Guid
    protected static readonly Guid _GuidRegistered = new("4f1c7b8d-8b7c-4e3a-9cbb-3ca3a2e4a2db");
    protected static readonly Guid _NewGuid = Guid.NewGuid();
    #endregion

    #region First Name
    protected static readonly string _FirstNameNull = null!;
    protected static readonly string _FirstNameShort = "Do";
    protected static readonly string _FirstNameLarge = "DouglasHasFirstNameBiggerRequired";
    protected static readonly string _FirstName = "Douglas";
    #endregion

    #region Last Name
    protected static readonly string _LastNameNull = null!;
    protected static readonly string _LastNameShort = "Ad";
    protected static readonly string _LastNameLarge = "AdamsHasLastNameBiggerRequiredTest";
    protected static readonly string _LastName = "Adams";
    #endregion

    #region Email Address
    protected static readonly string _EmailAddressNull = null!;
    protected static readonly string _EmailAddressShort = "d@a.c";
    protected static readonly string _EmailAddressLarge = "douglasadams42theanswertolifetheuniverseandeverything.douglasadams42theanswertolifetheuniverseandeverything.douglasadams@gmail.com";
    protected static readonly string _EmailAddressInvalid = "douglasadamscontato.com";
    protected static readonly string _EmailAddressAlreadyExists = "contato@contato.com";
    protected static readonly string _EmailAddressNotExists = "notexist@contato.com";
    protected static readonly string _EmailAddressAlreadyExistsOtherEmployee = "emailexists@contato.com";
    protected static readonly string _EmailAddress = "douglasadams@contato.com";
    #endregion

    #region Password
    protected static readonly string _PasswordNull = null!;
    protected static readonly string _PasswordShort = "ABC123";
    protected static readonly string _PasswordLarge = "aBcD1#2$3%4^5&6*7(8)9_0+QWERTYUIOP{}|ASDFGHJKL:ZXCVBNM?qwertyuiop[]asdfghjkl;zxcvbnm,.SN09vn98ud0S=-9HGfvdniojD0-987Nsdvm0iua-079gFBJKgopjkm";
    protected static readonly string _Password = "aBcD1#2$3%4^5&6*7(8)9_0+QWERTY";
    protected static readonly string _PasswordNotMatch = "A1B2C3D4E5";
    #endregion

    #region Role
    protected static readonly string _RoleNull = null!;
    protected static readonly string _RoleEmpty = "";
    protected static readonly string _RoleTooShort = "A";
    protected static readonly string _RoleTooLarge = "Programador Desenvolvedor";

    protected static readonly string _RoleNotExists = "Useer";
    protected static readonly string _Role = "Admin";
    #endregion

    #endregion

    public class AuthenticateEmployee
    {
        #region Invalid Email
        public readonly Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee.Request
            invalidEmailAddressIsNull = new(_EmailAddressNull, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee.Request
            invalidEmailAddressTooShort = new(_EmailAddressShort, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee.Request
            invalidEmailAddressTooLarge = new(_EmailAddressLarge, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee.Request
            invalidEmailAddress = new(_EmailAddressInvalid, _Password);
        #endregion

        #region Invalid Employee Not Exists
        public readonly Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee.Request
            invalidEmployeeNotFound = new(_EmailAddressNotExists, _Password);
        #endregion

        #region Invalid Password
        public readonly Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee.Request
            invalidPasswordNotMatch = new(_EmailAddress, _PasswordNotMatch);
        #endregion

        public readonly Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee.Request
            validEmployeeAuthorized = new(_EmailAddress, _Password);
    }

    public class CreateEmployee
    {
        #region Invalid First Name
        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidFirstNameIsNull = new(_FirstNameNull, _LastName, _EmailAddress, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidFirstNameTooShort = new(_FirstNameShort, _LastName, _EmailAddress, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidFirstNameTooLarge = new(_FirstNameLarge, _LastName, _EmailAddress, _Password);
        #endregion

        #region Invalid Last Name
        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidLastNameIsNull = new(_FirstName, _LastNameNull, _EmailAddress, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidLastNameTooShort = new(_FirstName, _LastNameShort, _EmailAddress, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidLastNameTooLarge = new(_FirstName, _LastNameLarge, _EmailAddress, _Password);
        #endregion

        #region Invalid Email
        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidEmailAddressIsNull = new(_FirstName, _LastName, _EmailAddressNull, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidEmailAddressTooShort = new(_FirstName, _LastName, _EmailAddressShort, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidEmailAddressTooLarge = new(_FirstName, _LastName, _EmailAddressLarge, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidEmailAddress = new(_FirstName, _LastName, _EmailAddressInvalid, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidEmailAddressAlreadyExists = new(_FirstName, _LastName, _EmailAddressAlreadyExists, _Password);
        #endregion

        #region Invalid Password
        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            invalidPasswordTooLarge = new(_FirstName, _LastName, _EmailAddress, _PasswordLarge);
        #endregion

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            validEmailAddressNew = new(_FirstName, _LastName, _EmailAddress, _Password);

        public readonly Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request
            validRequest = new(_FirstName, _LastName, _EmailAddress, _Password);
    }

    public class UpdateEmployee
    {
        #region Invalid First Name
        public readonly Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request
            invalidFirstNameIsNull = new(_GuidRegistered, _FirstNameNull, _LastName, _EmailAddress);

        public readonly Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request
            invalidFirstNameTooShort = new(_GuidRegistered, _FirstNameShort, _LastName, _EmailAddress);

        public readonly Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request
            invalidFirstNameTooLarge = new(_GuidRegistered, _FirstNameLarge, _LastName, _EmailAddress);
        #endregion

        #region Invalid Last Name
        public readonly Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request
            invalidLastNameIsNull = new(_GuidRegistered, _FirstName, _LastNameNull, _EmailAddress);

        public readonly Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request
            invalidLastNameTooShort = new(_GuidRegistered, _FirstName, _LastNameShort, _EmailAddress);

        public readonly Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request
            invalidLastNameTooLarge = new(_GuidRegistered, _FirstName, _LastNameLarge, _EmailAddress);
        #endregion

        #region Invalid Email
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
        #endregion

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

    public class SearchEmployeeId
    {
        public readonly Core.Contexts.EmployeeContext.UseCases.SearchEmployeeId.Request
            invalidEmployeeNotFound = new(_NewGuid);

        public readonly Core.Contexts.EmployeeContext.UseCases.SearchEmployeeId.Request
            validEmployee = new(_GuidRegistered);
    }

    public class AddRole
    {
        public readonly Core.Contexts.EmployeeContext.UseCases.AddRole.Request
            invalidRoleIsNull = new(_GuidRegistered, _RoleNull);

        public readonly Core.Contexts.EmployeeContext.UseCases.AddRole.Request
            invalidRoleIsEmpty = new(_GuidRegistered, _RoleEmpty);

        public readonly Core.Contexts.EmployeeContext.UseCases.AddRole.Request
            invalidRoleTooShort = new(_GuidRegistered, _RoleTooShort);

        public readonly Core.Contexts.EmployeeContext.UseCases.AddRole.Request
            invalidRoleTooLarge = new(_GuidRegistered, _RoleTooLarge);

        public readonly Core.Contexts.EmployeeContext.UseCases.AddRole.Request
            invalidEmployeeNotFound = new(_NewGuid, _Role);

        public readonly Core.Contexts.EmployeeContext.UseCases.AddRole.Request
            invalidRoleNotFound = new(_GuidRegistered, _RoleNotExists);

        public readonly Core.Contexts.EmployeeContext.UseCases.AddRole.Request
            validRequest = new(_GuidRegistered, _Role);
    }

    public class RemoveRole
    {
        public readonly Core.Contexts.EmployeeContext.UseCases.RemoveRole.Request
            invalidRoleIsNull = new(_GuidRegistered, _RoleNull);

        public readonly Core.Contexts.EmployeeContext.UseCases.RemoveRole.Request
            invalidRoleIsEmpty = new(_GuidRegistered, _RoleEmpty);

        public readonly Core.Contexts.EmployeeContext.UseCases.RemoveRole.Request
            invalidRoleTooShort = new(_GuidRegistered, _RoleTooShort);

        public readonly Core.Contexts.EmployeeContext.UseCases.RemoveRole.Request
            invalidRoleTooLarge = new(_GuidRegistered, _RoleTooLarge);

        public readonly Core.Contexts.EmployeeContext.UseCases.RemoveRole.Request
            invalidEmployeeNotFound = new(_NewGuid, _Role);

        public readonly Core.Contexts.EmployeeContext.UseCases.RemoveRole.Request
            invalidRoleNotFound = new(_GuidRegistered, _RoleNotExists);

        public readonly Core.Contexts.EmployeeContext.UseCases.RemoveRole.Request
            validRequest = new(_GuidRegistered, _Role);
    }
}
