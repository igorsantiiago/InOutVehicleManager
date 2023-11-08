using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee.Contracts;

namespace InOutVehicleManager.Tests.Contexts.EmployeeContext.UseCases.AuthenticateEmployee;

public class HandlerTest
{
    private readonly IRepository _repository;
    private readonly Handler _handler;
    private readonly Requests.AuthenticateEmployee requests;

    public HandlerTest()
    {
        _repository = new FakeRepository();
        _handler = new(_repository);
        requests = new();
    }

    #region Should Fail
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
    public async void Should_Fail_When_Employee_Not_Found()
    {
        var result = await _handler.Handle(requests.invalidEmployeeNotFound, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Password_Not_Match()
    {
        var result = await _handler.Handle(requests.invalidPasswordNotMatch, new CancellationToken());
        Assert.False(result.IsSuccess);
    }
    #endregion

    #region Should Succeed
    [Fact]
    public async void Should_Succeed_When_Employee_Email_And_Password_Match()
    {
        var result = await _handler.Handle(requests.validEmployeeAuthorized, new CancellationToken());
        Assert.True(result.IsSuccess);
    }
    #endregion
}
