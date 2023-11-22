﻿using FluentValidation.Results;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.SearchCompanyId;

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

public record ResponseData(Guid Id, string Name, string Cnpj, string Zipcode, string Street, int AddressNumber, string AddressLine, string City, string State, string? LandlinePhone, string? MobilePhone);