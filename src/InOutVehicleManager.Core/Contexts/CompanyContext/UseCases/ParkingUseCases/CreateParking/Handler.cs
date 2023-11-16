using FluentValidation.Results;
using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.CreateParking.Contracts;
using MediatR;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.CreateParking;

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
                return new Response("Requisição Inválida.", 400, result.Errors);
        }
        catch
        {
            return new Response("Falha ao validar a requisição", 500);
        }
        #endregion

        #region Create Parking
        Parking? parking;
        try
        {
            parking = new(request.TotalCarParkingSpaces, request.TotalMotorcycleParkingSpaces);
            if (parking == null)
                return new Response("Falha ao criar estacionamento para a empresa.", 400);

            await _repository.SaveAsync(parking, cancellationToken);
        }
        catch (Exception ex)
        {
            return new Response(ex.Message, 400);
        }
        #endregion

        #region Response
        return new Response("Estacionamento criado com sucesso.", new ResponseData(parking.Id, parking.TotalCarParkingSpaces, parking.TotalMotorcycleParkingSpaces, parking.IdCompany));
        #endregion
    }

    private static Parking CreateParking(Request request)
        => new(request.TotalCarParkingSpaces, request.TotalMotorcycleParkingSpaces);
}
