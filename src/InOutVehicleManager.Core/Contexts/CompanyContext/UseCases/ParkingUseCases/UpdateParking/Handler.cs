using FluentValidation.Results;
using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.UpdateParking.Contracts;
using MediatR;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.UpdateParking;

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
                return new Response("Requisição inválida.", 400, result.Errors);
        }
        catch
        {
            return new Response("Falha na validdação da requisição", 500);
        }
        #endregion

        #region Get CompanyParking
        Parking? parking;
        try
        {
            parking = await _repository.GetCompanyParkingByIdAsync(request.Id, cancellationToken);
            if (parking == null)
                return new Response("Estacionamento não encontrado.", 404);
        }
        catch
        {
            return new Response("Falha na busca de um estacionamento.", 500);
        }
        #endregion

        #region Upddate CompanyParking
        try
        {
            parking = UpdateCompanyParking(parking, request);
            await _repository.SaveAsync(parking, cancellationToken);
        }
        catch (Exception ex)
        {
            return new Response(ex.Message, 400);
        }
        #endregion

        #region Response
        return new Response("Estacionamento atualizado com sucesso.",
            new ResponseData(parking.Id, parking.TotalCarParkingSpaces, parking.TotalMotorcycleParkingSpaces, parking.IdCompany));
        #endregion
    }

    public static Parking UpdateCompanyParking(Parking parking, Request request)
    {
        parking.UpddateTotalCarSpaces(request.TotalCarParkingSpaces);
        parking.UpdateTotalMotorcycleSpaces(request.TotalMotorcycleParkingSpaces);
        parking.UpdateIdCompany(request.IdCompany);

        return parking;
    }
}
