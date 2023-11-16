using FluentValidation.Results;
using InOutVehicleManager.Core.Contexts.VehicleContext.Entities;
using InOutVehicleManager.Core.Contexts.VehicleContext.Enums;
using InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.CreateVehicle.Contracts;
using MediatR;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.CreateVehicle;

public class Handler : IRequestHandler<Request, Response>
{
    private readonly IRepository _repository;
    private readonly Specification _specification = new();

    public Handler(IRepository repository)
    {
        _repository = repository;
    }

    public async Task<Response> Handle(Request request, CancellationToken cancellationToken)
    {
        #region Validate Request
        try
        {
            ValidationResult result = _specification.Validate(request);

            if (!result.IsValid)
                return new Response("Erro: Requisição Inválida.", 400, result.Errors);
        }
        catch
        {
            return new Response("Erro: Falha ao validar a requisição.", 500);
        }
        #endregion

        #region Check if Vehicle already is registered
        try
        {
            var exists = await _repository.AnyAsync(request.LicensePlate, cancellationToken);
            if (exists)
                return new Response("Erro: A placa do veículo já esta cadastrada.", 400);
        }
        catch
        {
            return new Response("Erro: Falha ao verificar se o veículo já esta cadastrado.", 500);
        }
        #endregion

        #region Register Vehicle
        Vehicle? vehicle;
        try
        {
            vehicle = CreateVehicle(request);
            if (vehicle == null)
                return new Response("Erro: Categoria de veículo inválida.", 400);

            await _repository.SaveAsync(vehicle, cancellationToken);
        }
        catch (Exception ex)
        {
            return new Response(ex.Message, 400);
        }
        #endregion

        #region Response
        return new Response("Veículo cadastrado com sucesso.", new ResponseData(vehicle.Id, vehicle.Model, vehicle.Brand, vehicle.Color, vehicle.LicensePlate, vehicle.Type));
        #endregion
    }

    private static Vehicle? CreateVehicle(Request request)
    {
        if (Enum.TryParse(request.Type, true, out VehicleType type))
        {
            Vehicle vehicle = new(request.Model, request.Brand, request.Color, request.LicensePlate, type);
            return vehicle;
        }

        return null;
    }
}
