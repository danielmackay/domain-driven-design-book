using Cargo.Domain.Common;

namespace Cargo.Domain.Locations;

public class Location : IAggregateRoot
{
    public string PortCode { get; private set; }
}
