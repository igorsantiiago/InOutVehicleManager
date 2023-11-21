using FluentValidation.Results;

namespace InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.SearchVehicle;

public class Response : SharedContext.UseCases.Response
{
    public Response(string message, int status, IEnumerable<ValidationFailure>? notifications = null)
    {
        Message = message;
        Status = status;
        Notifications = notifications;
    }

    public Response(string message, ResponseData data)
    {
        Message = message;
        Status = 200;
        Notifications = null;
        Data = data;
    }

    public ResponseData? Data { get; set; }
}

public record ResponseData(Guid Id, string Model, string LicensePlate);
