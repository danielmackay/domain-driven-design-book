using Cargo.Domain.Cargos;
using Cargo.Domain.CarrierMovements;
using Cargo.Domain.Common;

namespace Cargo.Domain.HandlingEvents;

public class HandlingEvent : IAggregateRoot
{
    /// <summary>
    /// Auto-Generated, but Handling Event can be uniquely identified by a combination of:
    /// - CargoID
    /// - Completion Time
    /// - Event Type
    /// </summary>
    public Guid HandlingEventId { get; private set; }

    public DateTimeOffset CompletionTime { get; private set; }

    public string Type { get; private set; }

    public Cargos.Cargo Handled { get; private set; }

    public DeliveryHistory DeliveryHistory { get; private set; }

    public CarrierMovement? CarrierMovement { get; private set; }

    public HandlingEvent(Cargos.Cargo cargo, string eventType, DateTime timestamp)
    {
        Handled = cargo;
        Type = eventType;
        CompletionTime = timestamp;
        // DeliveryHistory = cargo.DeliveryHistory;
    }

    public static HandlingEvent NewLoading(Cargos.Cargo cargo, CarrierMovement loadedOnto, DateTime timestamp)
    {
        var handlingEvent = new HandlingEvent(cargo, "LOAD", timestamp);
        handlingEvent.SetCarrierMovement(loadedOnto);
        return handlingEvent;
    }

    private void SetCarrierMovement(CarrierMovement carrierMovement)
    {
        CarrierMovement = carrierMovement;
    }
}
