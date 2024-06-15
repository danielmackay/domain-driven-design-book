namespace Cargo.Domain;

public class DeliverySpecification
{
    public DateTimeOffset ArrivalTime { get; private set; }

    public Location Destination { get; private set; }
}
