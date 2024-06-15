using Cargo.Domain.Common;
using Cargo.Domain.Locations;

namespace Cargo.Domain.Cargos;

public class DeliverySpecification : IValueObject
{
    public DateTimeOffset ArrivalTime { get; private set; }

    public Location Destination { get; private set; }
}
