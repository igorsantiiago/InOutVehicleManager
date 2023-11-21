﻿using MediatR;

namespace InOutVehicleManager.Core.Contexts.EmployeeContext.UseCases.CreateEmployee;

public record Request(string FirstName, string LastName, string EmailAddress, string? Password = null) : IRequest<Response>;
