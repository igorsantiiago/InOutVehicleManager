using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.DeleteParking;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.DeleteParking.Contracts;

namespace InOutVehicleManager.Tests.Contexts.CompanyContext.UseCases.ParkingUseCases.DeleteParking;

public class HandlerTests
{
    private readonly IRepository _repository;
    private readonly Handler _handler;
    private readonly Requests.DeleteParking _requests;

    public HandlerTests()
    {
        _repository = new FakeRepository();
        _handler = new(_repository);
        _requests = new();
    }

    #region Should Fail
    [Fact]
    public async void Should_Fail_When_Parking_Not_Found()
    {
        var response = await _handler.Handle(_requests.invalidParkingNotFound, new CancellationToken());
        Assert.False(response.IsSuccess);
    }
    #endregion

    #region Should Succeed
    [Fact]
    public async void Should_Succeed_When_Parking_Is_Deleted()
    {
        var response = await _handler.Handle(_requests.validParkingDeleted, new CancellationToken());
        Assert.True(response.IsSuccess);
    }
    #endregion
}
