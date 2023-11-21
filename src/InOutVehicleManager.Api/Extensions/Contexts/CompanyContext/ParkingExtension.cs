using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InOutVehicleManager.Api.Extensions.Contexts.CompanyContext;

public static class ParkingExtension
{
    public static void AddParkingContext(this WebApplicationBuilder builder)
    {
        #region Create Parking
        builder.Services.AddTransient<
            Core.Contexts.CompanyContext.UseCases.ParkingUseCases.CreateParking.Contracts.IRepository,
            Infra.Contexts.CompanyContext.UseCases.ParkingUseCases.CreateParking.Repository
        >();
        #endregion

        #region Update Parking
        builder.Services.AddTransient<
            Core.Contexts.CompanyContext.UseCases.ParkingUseCases.UpdateParking.Contracts.IRepository,
            Infra.Contexts.CompanyContext.UseCases.ParkingUseCases.UpdateParking.Repository
        >();
        #endregion

        #region Delete Parking
        builder.Services.AddTransient<
            Core.Contexts.CompanyContext.UseCases.ParkingUseCases.DeleteParking.Contracts.IRepository,
            Infra.Contexts.CompanyContext.UseCases.ParkingUseCases.DeleteParking.Repository
        >();
        #endregion
    }

    public static void MapParkingEndPoint(this WebApplication app)
    {
        #region Create Parking
        app.MapPost("api/v1/company/parking/create", async (
            [FromBody] Core.Contexts.CompanyContext.UseCases.ParkingUseCases.CreateParking.Request request,
            [FromServices] IRequestHandler<
                Core.Contexts.CompanyContext.UseCases.ParkingUseCases.CreateParking.Request,
                Core.Contexts.CompanyContext.UseCases.ParkingUseCases.CreateParking.Response> handler) =>
        {
            var result = await handler.Handle(request, new CancellationToken());

            return result.IsSuccess
                ? Results.Created($"api/v1/company/parking/create/{result.Data?.Id}", result)
                : Results.Json(result, statusCode: result.Status);
        });
        #endregion

        #region Update Parking
        app.MapPut("api/v1/company/parking/update", async (
            [FromBody] Core.Contexts.CompanyContext.UseCases.ParkingUseCases.UpdateParking.Request request,
            [FromServices] IRequestHandler<
                Core.Contexts.CompanyContext.UseCases.ParkingUseCases.UpdateParking.Request,
                Core.Contexts.CompanyContext.UseCases.ParkingUseCases.UpdateParking.Response> handler) =>
        {
            var result = await handler.Handle(request, new CancellationToken());

            return result.IsSuccess
                ? Results.Ok(result)
                : Results.Json(result, statusCode: result.Status);
        });
        #endregion

        #region Delete Parking
        app.MapDelete("api/v1/company/parking/delete", async (
            [FromBody] Core.Contexts.CompanyContext.UseCases.ParkingUseCases.DeleteParking.Request request,
            [FromServices] IRequestHandler<
                Core.Contexts.CompanyContext.UseCases.ParkingUseCases.DeleteParking.Request,
                Core.Contexts.CompanyContext.UseCases.ParkingUseCases.DeleteParking.Response> handler) =>
        {
            var result = await handler.Handle(request, new CancellationToken());

            return result.IsSuccess
                ? Results.Ok(result)
                : Results.Json(result, statusCode: result.Status);
        });
        #endregion
    }
}
