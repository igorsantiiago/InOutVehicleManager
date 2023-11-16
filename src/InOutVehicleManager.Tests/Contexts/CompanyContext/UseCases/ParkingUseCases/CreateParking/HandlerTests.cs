using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.CreateParking;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.CreateParking.Contracts;

namespace InOutVehicleManager.Tests.Contexts.CompanyContext.UseCases.ParkingUseCases.CreateParking;

public class HandlerTests
{
    private readonly IRepository _repository;
    private readonly Handler _handler;
    private readonly Requests.CreateParking _request;

    public HandlerTests()
    {
        _repository = new FakeRepository();
        _handler = new(_repository);
        _request = new();
    }

    #region Should Fail

    #endregion

    #region Should Succeed
    [Fact]
    public async void Should_Succeed_When_Request_Is_Valid()
    {
        var response = await _handler.Handle(_request.validRequest, new CancellationToken());
        Assert.True(response.IsSuccess);
    }
    #endregion
}
