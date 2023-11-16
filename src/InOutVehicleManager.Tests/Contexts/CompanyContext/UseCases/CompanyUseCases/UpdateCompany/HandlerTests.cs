using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Contracts;

namespace InOutVehicleManager.Tests.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany;

public class HandlerTests
{
    private readonly IRepository _repository;
    private readonly Handler _handler;
    private readonly Requests.UpdateCompany _requests;

    public HandlerTests()
    {
        _repository = new FakeRepository();
        _handler = new(_repository);
        _requests = new();
    }

    #region Should Fail
    [Fact]
    public async void Should_Fail_When_Name_Is_Null()
    {
        var response = await _handler.Handle(_requests.invalidNameIsNull, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Name_Is_Empty()
    {
        var response = await _handler.Handle(_requests.invalidNameIsEmpty, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Name_Is_TooShort()
    {
        var response = await _handler.Handle(_requests.invalidNameTooShort, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Name_Is_TooLarge()
    {
        var response = await _handler.Handle(_requests.invalidNameTooLarge, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Cnpj_Is_Null()
    {
        var response = await _handler.Handle(_requests.invalidCnpjIsNull, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Cnpj_Is_Empty()
    {
        var response = await _handler.Handle(_requests.invalidCnpjIsEmpty, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Cnpj_Is_TooShort()
    {
        var response = await _handler.Handle(_requests.invalidCnpjTooShort, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Cnpj_Is_TooLarge()
    {
        var response = await _handler.Handle(_requests.invalidCnpjTooLarge, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Zipcode_Is_Null()
    {
        var response = await _handler.Handle(_requests.invalidZipcodeIsNull, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Zipcode_Is_Empty()
    {
        var response = await _handler.Handle(_requests.invalidZipcodeIsEmpty, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Zipcode_Is_TooShort()
    {
        var response = await _handler.Handle(_requests.invalidZipcodeTooShort, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Zipcode_Is_TooLarge()
    {
        var response = await _handler.Handle(_requests.invalidZipcodeTooLarge, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Street_Is_Null()
    {
        var response = await _handler.Handle(_requests.invalidStreetIsNull, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Street_Is_Empty()
    {
        var response = await _handler.Handle(_requests.invalidStreetIsEmpty, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Street_Is_TooShort()
    {
        var response = await _handler.Handle(_requests.invalidStreetTooShort, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Street_Is_TooLarge()
    {
        var response = await _handler.Handle(_requests.invalidStreetTooLarge, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_AddressLine_Is_Null()
    {
        var response = await _handler.Handle(_requests.invalidAddressLineIsNull, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_AddressLine_Is_Empty()
    {
        var response = await _handler.Handle(_requests.invalidAddressLineIsEmpty, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_AddressLine_Is_TooShort()
    {
        var response = await _handler.Handle(_requests.invalidAddressLineTooShort, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_AddressLine_Is_TooLarge()
    {
        var response = await _handler.Handle(_requests.invalidAddressLineTooLarge, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_City_Is_Null()
    {
        var response = await _handler.Handle(_requests.invalidCityIsNull, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_City_Is_Empty()
    {
        var response = await _handler.Handle(_requests.invalidCityIsEmpty, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_City_Is_TooShort()
    {
        var response = await _handler.Handle(_requests.invalidCityTooShort, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_City_Is_TooLarge()
    {
        var response = await _handler.Handle(_requests.invalidCityTooLarge, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_State_Is_Null()
    {
        var response = await _handler.Handle(_requests.invalidStateIsNull, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_State_Is_Empty()
    {
        var response = await _handler.Handle(_requests.invalidStateIsEmpty, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_State_Is_TooShort()
    {
        var response = await _handler.Handle(_requests.invalidStateTooShort, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_State_Is_TooLarge()
    {
        var response = await _handler.Handle(_requests.invalidStateTooLarge, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_LandlinePhone_Is_TooLarge()
    {
        var response = await _handler.Handle(_requests.invalidLandlinePhoneTooLarge, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_MobilePhone_Is_Too_Large()
    {
        var response = await _handler.Handle(_requests.invalidMobilePhoneTooLarge, new CancellationToken());
        Assert.False(response.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Company_Not_Found()
    {
        var response = await _handler.Handle(_requests.invalidCompanyNotFound, new CancellationToken());
        Assert.False(response.IsSuccess);
    }
    #endregion

    #region Should Succeed
    [Fact]
    public async void Should_Succeed_When_Update_Company()
    {
        var response = await _handler.Handle(_requests.validRequest, new CancellationToken());
        Assert.True(response.IsSuccess);
    }
    #endregion
}
