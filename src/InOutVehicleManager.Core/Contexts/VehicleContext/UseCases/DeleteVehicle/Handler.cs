using FluentValidation.Results;
using InOutVehicleManager.Core.Contexts.VehicleContext.Entities;
using InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.DeleteVehicle.Contracts;
using MediatR;

namespace InOutVehicleManager.Core.Contexts.VehicleContext.UseCases.DeleteVehicle;

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

        #region Get Vehicle
        Vehicle? vehicle;
        try
        {
            vehicle = await _repository.GetVehicleByIdAsync(request.Id, cancellationToken);
            if (vehicle == null)
                return new Response("Erro: Veículo não encontrado.", 404);
        }
        catch
        {
            return new Response("Erro: Falha ao buscar o veículo.", 500);
        }
        #endregion

        #region Delete Vehicle
        try
        {
            await _repository.DeleteVehicle(vehicle, cancellationToken);
        }
        catch (Exception ex)
        {
            return new Response(ex.Message, 400);
        }
        #endregion

        #region Response
        return new Response("Veículo excluído com sucesso.", new ResponseData(request.Id));
        #endregion
    }
}
