using MediatR;

namespace InOutVehicleManager.Core.Contexts.CompanyContext.UseCases.ParkingUseCases.CreateParking;

public record Request(int TotalCarParkingSpaces, int TotalMotorcycleParkingSpaces, Guid? IdCompany = null) : IRequest<Response>;
