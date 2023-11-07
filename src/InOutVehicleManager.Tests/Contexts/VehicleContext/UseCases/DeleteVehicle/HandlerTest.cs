using InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.DeleteVehicle;
using InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.DeleteVehicle.Contracts;

namespace InOutVehicleManager.Tests.Contexts.VehicleContext.UseCases.DeleteVehicle;

public class HandlerTest
{
    private readonly IRepository _repository;
    private readonly Handler _handler;
    private readonly Requests.DeleteRequests requests;

    public HandlerTest()
    {
        _repository = new FakeRepository();
        _handler = new(_repository);
        requests = new();
    }

    #region Should Fail
    [Fact]
    public async void Should_Fail_When_Vehicle_Not_Found()
    {
        var result = await _handler.Handle(requests.invalidVehicleNotFound, new CancellationToken());
        Assert.False(result.IsSuccess);
    }
    #endregion

    #region Should_Succeed
    [Fact]
    public async void Should_Succeed_When_Vehicle_Is_Deleted()
    {
        var result = await _handler.Handle(requests.validVehicleDeleted, new CancellationToken());
        Assert.True(result.IsSuccess);
    }
    #endregion
}
