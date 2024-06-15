namespace Cargo.Domain;

public class Cargo
{
    public Guid TrackingId { get; private set; }

    public Dictionary<Role, List<Customer>> Customers { get; private set; }

    public DeliveryHistory DeliveryHistory { get; private set; }

    public DeliverySpecification Goal { get; private set; }
}

public record Role(string Name);
