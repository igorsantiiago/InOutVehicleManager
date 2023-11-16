using FluentValidation.Results;
using InOutVehicleManager.Core.Contexts.CompanyContext.Entities;
using InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.DeleteParking.Contracts;
using MediatR;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.DeleteParking;

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
			return new Response("Falha ao validar a requisição.", 500);
		}
		#endregion

		#region Get CompanyParking
		Parking? parking;
		try
		{
            parking = await _repository.GetCompanyParkingByIdAsync(request.Id, cancellationToken);
			if (parking == null)
				return new Response("Estacionamento da empresa não encontrado.", 404);
		}
		catch
		{
			return new Response("Falha ao buscar estacionamento.", 500);
		}
		#endregion

		#region Delete CompanyParking
		try
		{
            await _repository.DeleteCompanyParking(parking, cancellationToken);
		}
		catch (Exception ex)
		{
			return new Response(ex.Message, 400);
		}
		#endregion

		#region Response
		return new Response("Estacionamento removido com sucesso.", new ResponseData(request.Id));
		#endregion
	}
}
