using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.DeleteEmployee;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.DeleteEmployee.Contracts;

namespace InOutVehicleManager.Tests.Contexts.EmployeeContext.UseCases.DeleteEmployee;

public class HandlerTest
{
    private readonly IRepository _repository;
    private readonly Handler _handler;
    private readonly Requests.DeleteEmployee requests;

    public HandlerTest()
    {
        _repository = new FakeRepository();
        _handler = new(_repository);
        requests = new();
    }

    #region Should Fail
    [Fact]
    public async void Should_Fail_When_Employee_Not_Found()
    {
        var result = await _handler.Handle(requests.invalidEmployeeNotFound, new CancellationToken());
        Assert.False(result.IsSuccess);
    }
    #endregion

    #region Should Succeed
    [Fact]
    public async void Should_Succeed_When_Employee_Is_Deleted()
    {
        var result = await _handler.Handle(requests.validRequest, new CancellationToken());
        Assert.True(result.IsSuccess);
    }
    #endregion
}
