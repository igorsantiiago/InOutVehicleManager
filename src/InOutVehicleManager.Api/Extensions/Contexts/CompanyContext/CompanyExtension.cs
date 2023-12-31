﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace InOutVehicleManager.Api.Extensions.Contexts.CompanyContext;

public static class CompanyExtension
{
    public static void AddCompanyContext(this WebApplicationBuilder builder)
    {
        #region Create Company
        builder.Services.AddTransient<
            Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Contracts.IRepository,
            Infra.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Repository
        >();
        #endregion

        #region Update Company
        builder.Services.AddTransient<
            Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Contracts.IRepository,
            Infra.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Repository
        >();
        #endregion

        #region Delete Company
        builder.Services.AddTransient<
            Core.Contexts.CompanyContext.UseCases.CompanyUseCases.DeleteCompany.Contracts.IRepository,
            Infra.Contexts.CompanyContext.UseCases.CompanyUseCases.DeleteCompany.Repository
        >();
        #endregion

        #region Search Company By Id
        builder.Services.AddTransient<
            Core.Contexts.CompanyContext.UseCases.CompanyUseCases.SearchCompanyId.Contracts.IRepository,
            Infra.Contexts.CompanyContext.UseCases.CompanyUseCases.SearchCompanyId.Repository
        >();
        #endregion

        #region Register Employee
        builder.Services.AddTransient<
            Core.Contexts.CompanyContext.UseCases.CompanyUseCases.RegisterEmployee.Contracts.IRepository,
            Infra.Contexts.CompanyContext.UseCases.CompanyUseCases.RegisterEmployee.Repository
        >();
        #endregion
    }

    public static void MapCompanyEndpoint(this WebApplication app)
    {
        #region Create Company
        app.MapPost("api/v1/company/create", async (
            [FromBody] Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request request,
            [FromServices] IRequestHandler <
                Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Request,
                Core.Contexts.CompanyContext.UseCases.CompanyUseCases.CreateCompany.Response> handler) =>
        {
            var result = await handler.Handle(request, new CancellationToken());

            return result.IsSuccess
                ? Results.Created($"api/v1/company/create/{result.Data?.Id}", result)
                : Results.Json(result, statusCode: result.Status);
        });
        #endregion

        #region Update Company
        app.MapPut("api/v1/company/update", async (
            [FromBody] Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request request,
            [FromServices] IRequestHandler <
                Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Request,
                Core.Contexts.CompanyContext.UseCases.CompanyUseCases.UpdateCompany.Response> handler) =>
        {
            var result = await handler.Handle(request, new CancellationToken());

            return result.IsSuccess
                ? Results.Ok(result)
                : Results.Json(result, statusCode: result.Status);
        });
        #endregion

        #region Delete Company
        app.MapDelete("api/v1/company/delete", async (
            [FromBody] Core.Contexts.CompanyContext.UseCases.CompanyUseCases.DeleteCompany.Request request,
            [FromServices] IRequestHandler<
                Core.Contexts.CompanyContext.UseCases.CompanyUseCases.DeleteCompany.Request,
                Core.Contexts.CompanyContext.UseCases.CompanyUseCases.DeleteCompany.Response> handler) =>
        {
            var result = await handler.Handle(request, new CancellationToken());

            return result.IsSuccess
                ? Results.Ok(result)
                : Results.Json(result, statusCode: result.Status);
        });
        #endregion

        #region Search Company By Id
        app.MapGet("api/v1/company/search/id/", async (
            [FromQuery] Guid id,
            [FromServices] IRequestHandler<
                Core.Contexts.CompanyContext.UseCases.CompanyUseCases.SearchCompanyId.Request,
                Core.Contexts.CompanyContext.UseCases.CompanyUseCases.SearchCompanyId.Response> handler) =>
        {
            var request = new Core.Contexts.CompanyContext.UseCases.CompanyUseCases.SearchCompanyId.Request(id);
            var result = await handler.Handle(request, new CancellationToken());

            return result.IsSuccess
                ? Results.Ok(result)
                : Results.Json(result, statusCode: result.Status);
        });
        #endregion

        #region Register Employee
        app.MapPut("api/v1/company/employee/register", async (
            [FromBody] Core.Contexts.CompanyContext.UseCases.CompanyUseCases.RegisterEmployee.Request request,
            [FromServices] IRequestHandler<
                Core.Contexts.CompanyContext.UseCases.CompanyUseCases.RegisterEmployee.Request,
                Core.Contexts.CompanyContext.UseCases.CompanyUseCases.RegisterEmployee.Response> handler) =>
        {
            var result = await handler.Handle(request, new CancellationToken());

            return result.IsSuccess
                ? Results.Ok(result)
                : Results.Json(result, statusCode: result.Status);
        });
        #endregion
    }
}
