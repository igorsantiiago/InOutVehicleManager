using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.CreateEmployee;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Contracts;

namespace InOutVehicleManager.Tests.Contexts.EmployeeContext.UseCases.CreateEmployee;

public class HandlerTest
{
    private readonly IRepository _repository;
    private readonly Handler _handler;
    private readonly Requests.CreateEmployee requests;

    public HandlerTest()
    {
        _repository = new FakeRepository();
        _handler = new(_repository);
        requests = new();
    }

    #region Should Fail
    [Fact]
    public async void Should_Fail_When_FirstName_Is_Null_Or_Empty()
    {
        var result = await _handler.Handle(requests.invalidFirstNameIsNull, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_FirstName_Is_Too_Short()
    {
        var result = await _handler.Handle(requests.invalidFirstNameTooShort, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_FirstName_Is_Too_Large()
    {
        var result = await _handler.Handle(requests.invalidFirstNameTooLarge, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_LastName_Is_Null_Or_Empty()
    {
        var result = await _handler.Handle(requests.invalidLastNameIsNull, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_LastName_Is_Too_Short()
    {
        var result = await _handler.Handle(requests.invalidLastNameTooShort, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_LastName_Is_Too_Large()
    {
        var result = await _handler.Handle(requests.invalidLastNameTooLarge, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Cpf_Is_Null()
    {
        var result = await _handler.Handle(requests.invalidCpfIsNull, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Cpf_Is_Empty()
    {
        var result = await _handler.Handle(requests.invalidCpfIsEmpty, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Cpf_Is_Too_Short()
    {
        var result = await _handler.Handle(requests.invalidCpfTooShort, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Cpf_Is_Too_Large()
    {
        var result = await _handler.Handle(requests.invalidCpfTooLarge, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_EmailAddress_Is_Null_Or_Empty()
    {
        var result = await _handler.Handle(requests.invalidEmailAddressIsNull, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_EmailAddress_Is_Too_Short()
    {
        var result = await _handler.Handle(requests.invalidEmailAddressTooShort, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_EmailAddress_Is_Too_Large()
    {
        var result = await _handler.Handle(requests.invalidEmailAddressTooLarge, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_EmailAddress_Is_Invalid()
    {
        var result = await _handler.Handle(requests.invalidEmailAddress, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_EmailAddress_Already_Exists()
    {
        var result = await _handler.Handle(requests.invalidEmailAddressAlreadyExists, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Password_Is_Too_Large()
    {
        var result = await _handler.Handle(requests.invalidPasswordTooLarge, new CancellationToken());
        Assert.False(result.IsSuccess);
    }
    #endregion

    #region Should Succeed
    [Fact]
    public async void Should_Succeed_When_New_Email()
    {
        var result = await _handler.Handle(requests.validEmailAddressNew, new CancellationToken());
        Assert.True(result.IsSuccess);
    }

    [Fact]
    public async void Should_Succeed_When_Employee_Is_Created()
    {
        var result = await _handler.Handle(requests.validRequest, new CancellationToken());
        Assert.True(result.IsSuccess);
    }
    #endregion
}
