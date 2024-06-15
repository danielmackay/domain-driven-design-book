using Cargo.Domain.Common;

namespace Cargo.Domain;

public class Cargo : IEntity
{
    /// <summary>
    /// Auto generated ID
    /// </summary>
    public Guid TrackingId { get; private set; }

    public Dictionary<Role, List<Customer>> Customers { get; private set; }

    public DeliveryHistory DeliveryHistory { get; private set; }

    public DeliverySpecification Goal { get; private set; }
}
