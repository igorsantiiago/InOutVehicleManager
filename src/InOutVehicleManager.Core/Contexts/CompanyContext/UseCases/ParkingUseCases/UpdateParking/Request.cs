using MediatR;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.UpdateParking;

public record Request(Guid Id, int TotalCarParkingSpaces, int TotalMotorcycleParkingSpaces, Guid? IdCompany = null) : IRequest<Response>;
