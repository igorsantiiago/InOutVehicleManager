﻿using FluentValidation.Results;

namespace InOutVehicleManager.Core.Contexts.SharedContext.UseCases;

public abstract class Response
{
    public string? Message { get; set; } = string.Empty;
    public int Status { get; set; }
    public bool IsSuccess => Status is >= 200 and <= 299;
    public IEnumerable<ValidationFailure>? Notifications { get; set; }
}
