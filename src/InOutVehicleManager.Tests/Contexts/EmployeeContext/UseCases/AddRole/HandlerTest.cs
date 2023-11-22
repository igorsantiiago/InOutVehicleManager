using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AddRole;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AddRole.Contracts;

namespace InOutVehicleManager.Tests.Contexts.EmployeeContext.UseCases.AddRole;

public class HandlerTest
{
    private readonly IRepository _repository;
    private readonly Handler _handler;
    private readonly Requests.AddRole _requests;

    public HandlerTest()
    {
        _repository = new FakeRepository();
        _handler = new(_repository);
        _requests = new();
    }

    #region Should Fail
    [Fact]
    public async void Should_Fail_When_Role_Null()
    {
        var result = await _handler.Handle(_requests.invalidRoleIsNull, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Role_Empty()
    {
        var result = await _handler.Handle(_requests.invalidRoleIsEmpty, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Role_TooShort()
    {
        var result = await _handler.Handle(_requests.invalidRoleTooShort, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Role_TooLarge()
    {
        var result = await _handler.Handle(_requests.invalidRoleTooLarge, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Employee_Not_Found()
    {
        var result = await _handler.Handle(_requests.invalidEmployeeNotFound, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Role_Not_Found()
    {
        var result = await _handler.Handle(_requests.invalidRoleNotFound, new CancellationToken());
        Assert.False(result.IsSuccess);
    }
    #endregion

    #region Should Succeed
    [Fact]
    public async void Should_Succeed_When_Role_Added()
    {
        var result = await _handler.Handle(_requests.validRequest, new CancellationToken());
        Assert.True(result.IsSuccess);
    }
    #endregion
}
