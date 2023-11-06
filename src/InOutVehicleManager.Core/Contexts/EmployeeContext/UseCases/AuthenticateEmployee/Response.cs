using FluentValidation.Results;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee;

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

public class ResponseData
{
    public string Id { get; set; }  = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;
    public string[] Roles { get; set; } = Array.Empty<string>();
}
