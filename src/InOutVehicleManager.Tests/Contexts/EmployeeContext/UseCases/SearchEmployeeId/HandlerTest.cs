using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.SearchEmployeeId;
using InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.SearchEmployeeId.Contracts;

namespace InOutVehicleManager.Tests.Contexts.EmployeeContext.UseCases.SearchEmployeeId;

public class HandlerTest
{
    private readonly IRepository _repository;
    private readonly Handler _handler;
    private readonly Requests.SearchEmployeeId _requests;

    public HandlerTest()
    {
        _repository = new FakeRepository();
        _handler = new(_repository);
        _requests = new();
    }

    #region Should Fail
    [Fact]
    public async void Should_Fail_When_Employee_Not_Found()
    {
        var result = await _handler.Handle(_requests.invalidEmployeeNotFound, new CancellationToken());
        Assert.False(result.IsSuccess);
    }
    #endregion

    #region Should Succeed
    [Fact]
    public async void Should_Succeed_When_Find_Employee()
    {
        var result = await _handler.Handle(_requests.validEmployee, new CancellationToken());
        Assert.True(result.IsSuccess);
    }
    #endregion
}
