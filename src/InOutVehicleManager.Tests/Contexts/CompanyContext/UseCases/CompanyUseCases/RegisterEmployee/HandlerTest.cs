using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.RegisterEmployee;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.RegisterEmployee.Contracts;

namespace InOutVehicleManager.Tests.Contexts.CompanyContext.UseCases.CompanyUseCases.RegisterEmployee;

public class HandlerTest
{
    private readonly IRepository _repository;
    private readonly Handler _handler;
    private readonly Requests.RegisterEmployee _requests;

    public HandlerTest()
    {
        _repository = new FakeRepository();
        _handler = new(_repository);
        _requests = new();
    }

    #region Should Fail

    #region Invalid CNPJ
    [Fact]
    public async void Should_Fail_When_Cnpj_Is_Null()
    {
        var result = await _handler.Handle(_requests.invalidCnpjIsNull, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Cnpj_Is_Empty()
    {
        var result = await _handler.Handle(_requests.invalidCnpjIsEmpty, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Cnpj_TooShort()
    {
        var result = await _handler.Handle(_requests.invalidCnpjTooShort, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Cnpj_TooLarge()
    {
        var result = await _handler.Handle(_requests.invalidCnpjTooLarge, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Cnpj_NotFound()
    {
        var result = await _handler.Handle(_requests.invalidCnpjNotFound, new CancellationToken());
        Assert.False(result.IsSuccess);
    }
    #endregion

    #region Invalid CPF
    [Fact]
    public async void Should_Fail_When_Cpf_Is_Null()
    {
        var result = await _handler.Handle(_requests.invalidCpfIsNull, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Cpf_Is_Empty()
    {
        var result = await _handler.Handle(_requests.invalidCpfIsEmpty, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Cpf_TooShort()
    {
        var result = await _handler.Handle(_requests.invalidCpfTooShort, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Cpf_TooLarge()
    {
        var result = await _handler.Handle(_requests.invalidCpfTooLarge, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Cpf_NotFound()
    {
        var result = await _handler.Handle(_requests.invalidCpfNotFound, new CancellationToken());
        Assert.False(result.IsSuccess);
    }
    #endregion

    #endregion

    #region Should Succeed
    [Fact]
    public async void Should_Succeed_When_Employee_Registered_At_Company()
    {
        var result = await _handler.Handle(_requests.validRequest, new CancellationToken());
        Assert.True(result.IsSuccess);
    }
    #endregion
}
