using FluentValidation.Results;
using InOutVehicleManager.Core.Contexts.VehicleContext.Entities;
using InOutVehicleManager.Core.Contexts.VehicleContext.Enums;
using InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.UpdateVehicle.Contracts;
using MediatR;

namespace InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.UpdateVehicle;

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
                return new Response("Invalid Request.", 500, result.Errors);
        }
        catch
        {
            return new Response("Unable to validate request.", 500);
        }
        #endregion

        #region Get Vehicle
        Vehicle? vehicle;
        try
        {
            vehicle = await _repository.GetVehicleByIdAsync(request.Id, cancellationToken);
            if (vehicle == null)
                return new Response("Vehicle not found.", 404);
        }
        catch
        {
            return new Response("Unable to retrieve vehicle.", 500);
        }
        #endregion

        #region Update Vehicle
        try
        {
            vehicle = UpdateVehicle(vehicle, request);
            if (vehicle == null)
                return new Response("Invalid Vehicle Type", 400);

            await _repository.SaveAsync(vehicle, cancellationToken);
        }
        catch(Exception ex)
        {
            return new Response(ex.Message, 400);
        }
        #endregion

        #region Response
        return new Response("Vehicle updated successfully.", 
            new ResponseData(vehicle.Id, vehicle.Model, vehicle.Brand, vehicle.Color, vehicle.LicensePlate, vehicle.Type.ToString()));
        #endregion
    }

    private static Vehicle? UpdateVehicle(Vehicle vehicle, Request request)
    {
        if (Enum.TryParse(request.Type, true, out VehicleType type))
        {
            vehicle.UpdateModel(request.Model);
            vehicle.UpdateBrand(request.Brand);
            vehicle.UpdateColor(request.Color);
            vehicle.UpdateLicensePlate(request.LicensePlate);
            vehicle.UpdateVehicleType(type);

            return vehicle;
        }

        return null;
    }
}
