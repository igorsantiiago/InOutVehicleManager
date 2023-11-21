using InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.SearchVehicle;
using InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.SearchVehicle.Contracts;

namespace InOutVehicleManager.Tests.Contexts.VehicleContext.UseCases.SearchVehicle;

public class HandlerTest
{
    private readonly IRepository _repository;
    private readonly Handler _handler;
    private readonly Requests.SearchVehicleRequests _requests;

    public HandlerTest()
    {
        _repository = new FakeRepository();
        _handler = new(_repository);
        _requests = new();
    }

    #region Should Fail
    [Fact]
    public async void Should_Fail_When_Vehicle_Not_Found()
    {
        var result = await _handler.Handle(_requests._invalidVehicleNotFound, new CancellationToken());
        Assert.False(result.IsSuccess);
    }
    #endregion

    #region Should Succeed
    [Fact]
    public async void Should_Succeed_When_Vehicle_Is_Found()
    {
        var result = await _handler.Handle(_requests._validVehicle, new CancellationToken());
        Assert.True(result.IsSuccess);
    }
    #endregion
}
