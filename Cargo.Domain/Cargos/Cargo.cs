using Cargo.Domain.Common;
using Cargo.Domain.Customers;
using Cargo.Domain.HandlingEvents;

namespace Cargo.Domain.Cargos;

public class Cargo : IAggregateRoot
{
    /// <summary>
    /// Auto generated ID
    /// </summary>
    public string TrackingId { get; private set; }

    public Dictionary<Role, List<Customer>> CustomerRoles { get; private set; }

    public DeliveryHistory DeliveryHistory { get; private set; }

    public DeliverySpecification Goal { get; private set; }


    public Cargo(string id)
    {
        TrackingId = id;
        DeliveryHistory = new DeliveryHistory(this);
        CustomerRoles = new Dictionary<Role, List<Customer>>();
    }
}
