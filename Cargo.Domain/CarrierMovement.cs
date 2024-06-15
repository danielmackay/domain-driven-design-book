using Cargo.Domain.Common;

namespace Cargo.Domain;

public class CarrierMovement : IEntity
{
    /// <summary>
    /// Provided from External System
    /// </summary>
    public Guid ScheduleId { get; private set; }

    public Location From { get; private set; }

    public Location To { get; private set; }
}
