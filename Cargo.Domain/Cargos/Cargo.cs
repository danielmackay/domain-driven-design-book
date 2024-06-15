using Cargo.Domain.Common;
using Cargo.Domain.Customers;
using Cargo.Domain.HandlingEvents;

namespace Cargo.Domain.Cargos;

public class Cargo : IAggregateRoot
{
    /// <summary>
    /// Auto generated ID
    /// </summary>
    public Guid TrackingId { get; private set; }

    public Dictionary<Role, List<Customer>> Customers { get; private set; }

    public DeliveryHistory DeliveryHistory { get; private set; }

    public DeliverySpecification Goal { get; private set; }

    public List<HandlingEvent> HandlingEvents { get; private set; }
}
