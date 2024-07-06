using Cargo.Domain.Locations;

namespace Cargo.Domain.CarrierMovements;

public interface ICarrierMovementRepository
{
    CarrierMovement FindByScheduleId(string id);
    CarrierMovement FindByFromTo(Location from, Location to);
}
