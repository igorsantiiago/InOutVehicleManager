using InOutVehicleManager.Core.Contexts.VehicleContext.Entities;
using InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.SearchVehicle.Contracts;
using MediatR;

namespace InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.SearchVehicle;

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
            var result = _specification.Validate(request);
            if (!result.IsValid)
                return new Response("Erro: Requisição Inválida.", 400, result.Errors);
        }
        catch
        {
            return new Response("Erro: Falha ao validar a requisição.", 500);
        }
        #endregion

        #region Get Vehicle
        Vehicle? vehicle;
        try
        {
            vehicle = await _repository.GetVehicleByIdAsync(request.Id, cancellationToken);
            if (vehicle == null)
                return new Response("O veículo não foi encontrado.", 404);
        }
        catch
        {
            return new Response("Falha ao buscar o veículo.", 500);
        }
        #endregion

        #region Result
        return new Response("Veículo encontrado.", new ResponseData(vehicle.Id, vehicle.Model, vehicle.LicensePlate));
        #endregion
    }
}
