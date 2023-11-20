﻿using System.Security.Claims;

namespace InOutVehicleManager.Api.Extensions;

public static class ClaimsPrincipalExtension
{
    public static string Id(this ClaimsPrincipal user)
        => user.Claims.FirstOrDefault(x => x.Type == "Id")?.Value ?? string.Empty;

    public static string Email(this ClaimsPrincipal user)
        => user.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value ?? string.Empty;
}
