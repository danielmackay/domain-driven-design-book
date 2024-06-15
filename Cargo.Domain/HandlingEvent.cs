using Cargo.Domain.Common;

namespace Cargo.Domain;

public class HandlingEvent : IEntity
{
    /// <summary>
    /// Auto-Generated, but Handling Event can be uniquely identified by a combination of:
    /// - CargoID
    /// - Completion Time
    /// - Type
    /// </summary>
    public Guid HandlingEventId { get; private set; }

    public DateTimeOffset CompletionTime { get; private set; }

    public string Type { get; private set; }

    public Cargo Handled { get; private set; }

    public DeliveryHistory DeliveryHistory { get; private set; }

    public CarrierMovement? CarrierMovement { get; private set; }
}
