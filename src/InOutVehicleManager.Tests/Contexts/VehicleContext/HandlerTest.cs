using InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.CreateVehicle;

namespace InOutVehicleManager.Tests.Contexts.VehicleContext;

public class HandlerTest
{

    [Fact]
    public async void Should_Succeed()
    {
        var request = new Request("Cayenne", "Porsche", "Branca", "B1C2D3E4", "Car");
        var _repository = new FakeRepository();
        var handler = new Handler(_repository);
        var result = await handler.Handle(request, new CancellationToken());
        Assert.True(result.IsSuccess);
    }

    [Fact]
    public async void Should_Fail()
    {
        var request = new Request("Cayenne", "Porsche", "Branca", "B1C2D3E4", "Carro");
        var _repository = new FakeRepository();
        var handler = new Handler(_repository);
        var result = await handler.Handle(request, new CancellationToken());
        Assert.False(result.IsSuccess);
    }
}
