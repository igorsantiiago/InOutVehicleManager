using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.DeleteCompany;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.DeleteCompany.Contracts;

namespace InOutVehicleManager.Tests.Contexts.CompanyContext.UseCases.CompanyUseCases.DeleteCompany;

public class HandlerTests
{
    private readonly IRepository _repository;
    private readonly Handler _handler;
    private readonly Requests.DeleteCompany _requests;

    public HandlerTests()
    {
        _repository = new FakeRepository();
        _handler = new(_repository);
        _requests = new();
    }

    #region Should Fail
    [Fact]
    public async void Should_Fail_When_Company_Not_Found()
    {
        var response = await _handler.Handle(_requests._invalidCompanyNotFound, new CancellationToken());
        Assert.False(response.IsSuccess);
    }
    #endregion

    #region Should Succeed
    [Fact]
    public async void Should_Succeed_When_Delete_Company()
    {
        var response = await _handler.Handle(_requests._validRequest, new CancellationToken());
        Assert.True(response.IsSuccess);
    }
    #endregion
}
