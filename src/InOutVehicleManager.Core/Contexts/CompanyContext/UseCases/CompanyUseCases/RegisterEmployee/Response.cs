using FluentValidation.Results;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.RegisterEmployee;
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

public record ResponseData(string CompanyCnpj, string CompanyName, string EmployeeCpf, string EmployeeName);
