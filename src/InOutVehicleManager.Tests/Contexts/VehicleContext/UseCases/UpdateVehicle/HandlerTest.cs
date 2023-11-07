using InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.UpdateVehicle;
using InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Contracts;

namespace InOutVehicleManager.Tests.Contexts.VehicleContext.UseCases.UpdateVehicle;

public class HandlerTest
{
    private readonly IRepository _repository;
    private readonly Handler _handler;
    private readonly Requests.UpdateRequests requests;

    public HandlerTest()
    {
        _repository = new FakeRepository();
        _handler = new(_repository);
        requests = new();
    }

    #region Should_Fail
    [Fact]
    public async void Should_Fail_When_Model_Is_Null_Or_Empty()
    {
        var result = await _handler.Handle(requests.invalidModelNullOrEmpty, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Model_Is_Too_Short()
    {
        var result = await _handler.Handle(requests.invalidModelTooShort, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Model_Is_Too_Large()
    {
        var result = await _handler.Handle(requests.invalidModelTooLarge, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Brand_Is_Null_Or_Empty()
    {
        var result = await _handler.Handle(requests.invalidBrandNullOrEmpty, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Brand_Is_Too_Short()
    {
        var result = await _handler.Handle(requests.invalidBrandTooShort, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Brand_Is_Too_Large()
    {
        var result = await _handler.Handle(requests.invalidBrandTooLarge, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Color_Is_Null_Or_Empty()
    {
        var result = await _handler.Handle(requests.invalidColorNullOrEmpty, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Color_Is_Too_Short()
    {
        var result = await _handler.Handle(requests.invalidColorTooShort, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Color_Is_Too_Large()
    {
        var result = await _handler.Handle(requests.invalidColorTooLarge, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_LicensePlate_Is_Null_Or_Empty()
    {
        var result = await _handler.Handle(requests.invalidLicensePlateNullOrEmpty, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_LicensePlate_Is_Too_Short()
    {
        var result = await _handler.Handle(requests.invalidLicensePlateTooShort, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_LicensePlate_Is_Too_Large()
    {
        var result = await _handler.Handle(requests.invalidLicensePlateTooLarge, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Type_Is_Null_Or_Empty()
    {
        var result = await _handler.Handle(requests.invalidTypeNullOrEmpty, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Type_Not_Exists()
    {
        var result = await _handler.Handle(requests.invalidTypeNotExists, new CancellationToken());
        Assert.False(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail_When_Id_Not_Exists()
    {
        var result = await _handler.Handle(requests.invalidIdNotExist, new CancellationToken());
        Assert.False(result.IsSuccess);
    }
    #endregion

    #region Should_Succeed
    [Fact]
    public async void Should_Succeed_When_LicensePlate_Is_New()
    {
        
        var result = await _handler.Handle(requests.validLicensePlateNew, new CancellationToken());
        Assert.True(result.IsSuccess);
    }

    [Fact]
    public async void Should_Succeed_When_Request_Is_Valid()
    {
        var result = await _handler.Handle(requests.validRequest, new CancellationToken());
        Assert.True(result.IsSuccess);
    }
    #endregion
}
