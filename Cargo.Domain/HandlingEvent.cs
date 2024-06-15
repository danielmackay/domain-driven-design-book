namespace Cargo.Domain;

public class HandlingEvent
{
    public DateTimeOffset CompletionTime { get; private set; }
    public string Type { get; private set; }

    public Cargo Handled { get; private set; }

    public DeliveryHistory DeliveryHistory { get; private set; }

    public CarrierMovement CarrierMovement { get; private set; }
}
