using Cargo.Domain.Common;

namespace Cargo.Domain;

public class DeliverySpecification : IValueObject
{
    public DateTimeOffset ArrivalTime { get; private set; }

    public Location Destination { get; private set; }
}
