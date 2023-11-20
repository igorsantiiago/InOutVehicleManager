using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InOutVehicleManager.Api.Extensions.Contexts.VehicleContext;

public static class VehicleExtension
{
    public static void AddVehicleContext(this WebApplicationBuilder builder)
    {
        #region Create Vehicle
        builder.Services.AddTransient<
            Core.Contexts.VehicleContext.UseCases.CreateVehicle.Contracts.IRepository,
            Infra.Contexts.VehicleContext.UseCases.CreateVehicle.Repository
        >();
        #endregion

        #region Update Vehicle
        builder.Services.AddTransient<
            Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Contracts.IRepository,
            Infra.Contexts.VehicleContext.UseCases.UpdateVehicle.Repository
        >();
        #endregion

        #region Delete Vehicle
        builder.Services.AddTransient<
            Core.Contexts.VehicleContext.UseCases.DeleteVehicle.Contracts.IRepository,
            Infra.Contexts.VehicleContext.UseCases.DeleteVehicle.Repository
        >();
        #endregion
    }

    public static void MapVehicleEndpoints(this WebApplication app)
    {
        #region Create Vehicle
        app.MapPost("api/v1/vehicle/create", async (
            [FromBody] Core.Contexts.VehicleContext.UseCases.CreateVehicle.Request request,
            [FromServices] IRequestHandler<
                Core.Contexts.VehicleContext.UseCases.CreateVehicle.Request,
                Core.Contexts.VehicleContext.UseCases.CreateVehicle.Response> handler) =>
        {
            var result = await handler.Handle(request, new CancellationToken());
            return result.IsSuccess
                ? Results.Created($"api/v1/vehicle/create/{result.Data?.Id}", result)
                : Results.Json(result, statusCode: result.Status);
        });
        #endregion

        #region Update Vehicle
        app.MapPut("api/v1/vehicle/update", async (
            [FromBody] Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Request request,
            [FromServices] IRequestHandler<
                Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Request,
                Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Response> handler) =>
        {
            var result = await handler.Handle(request, new CancellationToken());
            return result.IsSuccess
                ? Results.Ok(result)
                : Results.Json(result, statusCode: result.Status);
        });
        #endregion

        #region Delete Vehicle
        app.MapDelete("api/v1/vehicle/delete", async (
            [FromBody] Core.Contexts.VehicleContext.UseCases.DeleteVehicle.Request request,
            [FromServices] IRequestHandler<
                Core.Contexts.VehicleContext.UseCases.DeleteVehicle.Request,
                Core.Contexts.VehicleContext.UseCases.DeleteVehicle.Response> Handler) =>
        {
            var result = await Handler.Handle(request, new CancellationToken());
            return result.IsSuccess
                ? Results.Ok("Veículo removido com sucesso.")
                : Results.Json(result, statusCode: result.Status);
        });
        #endregion
    }
}
