using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InOutVehicleManager.Api.Extensions.Contexts.EmployeeContext;

public static class EmployeeExtension
{
    public static void AddEmployeeContext(this WebApplicationBuilder builder)
    {
        #region Authenticate Employee
        builder.Services.AddTransient<
            Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee.Contracts.IRepository,
            Infra.Contexts.EmployeeContext.UseCases.AuthenticateEmployee.Repository
        >();
        #endregion

        #region Create Employee
        builder.Services.AddTransient<
            Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Contracts.IRepository,
            Infra.Contexts.EmployeeContext.UseCases.CreateEmployee.Repository
        >();
        #endregion

        #region Update Employee
        builder.Services.AddTransient<
            Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Contracts.IRepository,
            Infra.Contexts.EmployeeContext.UseCases.UpdateEmployee.Repository
        >();
        #endregion

        #region Delete Employee
        builder.Services.AddTransient<
            Core.Contexts.EmployeeContext.UseCases.DeleteEmployee.Contracts.IRepository,
            Infra.Contexts.EmployeeContext.UseCases.DeleteEmployee.Repository
        >();
        #endregion

        #region Search Employee By Id
        builder.Services.AddTransient<
            Core.Contexts.EmployeeContext.UseCases.SearchEmployeeId.Contracts.IRepository,
            Infra.Contexts.EmployeeContext.UseCases.SearchEmployeeId.Repository
        >();
        #endregion
    }

    public static void MapEmployeeEndpoint(this WebApplication app)
    {
        #region Authenticate Employee
        app.MapPost("api/v1/employee/authenticate/", async (
            [FromBody] Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee.Request request,
            [FromServices] IRequestHandler<
                Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee.Request,
                Core.Contexts.EmployeeContext.UseCases.AuthenticateEmployee.Response> handler) =>
        {
            var result = await handler.Handle(request, new CancellationToken());

            return result.IsSuccess
                ? Results.Ok(result)
                : Results.Json(result, statusCode: result.Status);
        });
        #endregion

        #region Create Employee
        app.MapPost("api/v1/employee/create", async (
            [FromBody] Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request request,
            [FromServices] IRequestHandler <
                Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Request,
                Core.Contexts.EmployeeContext.UseCases.CreateEmployee.Response> handler) =>
        {
            var result = await handler.Handle(request, new CancellationToken());

            return result.IsSuccess
                ? Results.Created($"api/v1/employee/create/{result.Data?.Id}", result)
                : Results.Json(result, statusCode: result.Status);
        });
        #endregion

        #region Update Employee
        app.MapPut("api/v1/employee/update", async (
            [FromBody] Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request request,
            [FromServices] IRequestHandler<
                Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Request,
                Core.Contexts.EmployeeContext.UseCases.UpdateEmployee.Response> handler) =>
        {
            var result = await handler.Handle(request, new CancellationToken());

            return result.IsSuccess
                ? Results.Ok(result)
                : Results.Json(result, statusCode: result.Status);
        });
        #endregion

        #region Delete Employee
        app.MapDelete("api/v1/employee/delete", async (
            [FromBody] Core.Contexts.EmployeeContext.UseCases.DeleteEmployee.Request request,
            [FromServices] IRequestHandler<
                Core.Contexts.EmployeeContext.UseCases.DeleteEmployee.Request,
                Core.Contexts.EmployeeContext.UseCases.DeleteEmployee.Response> handler) =>
        {
            var result = await handler.Handle(request, new CancellationToken());

            return result.IsSuccess
                ? Results.Ok(result)
                : Results.Json(result, statusCode: result.Status);
        });
        #endregion

        #region Search Employee By Id
        app.MapGet("api/v1/employee/search/id/", async (
            [FromQuery] Guid id,
            [FromServices] IRequestHandler<
                Core.Contexts.EmployeeContext.UseCases.SearchEmployeeId.Request,
                Core.Contexts.EmployeeContext.UseCases.SearchEmployeeId.Response> handler) =>
        {
            var request = new Core.Contexts.EmployeeContext.UseCases.SearchEmployeeId.Request(id);
            var result = await handler.Handle(request, new CancellationToken());

            return result.IsSuccess
                ? Results.Ok(result)
                : Results.Json(result, statusCode: result.Status);
        });
        #endregion
    }
}
