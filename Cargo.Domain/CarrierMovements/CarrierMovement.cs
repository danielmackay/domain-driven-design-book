using Cargo.Domain.Common;
using Cargo.Domain.Locations;

namespace Cargo.Domain.CarrierMovements;

public class CarrierMovement : IAggregateRoot
{
    /// <summary>
    /// Provided from External System
    /// </summary>
    public Guid ScheduleId { get; private set; }

    public Location From { get; private set; }

    public Location To { get; private set; }
}
