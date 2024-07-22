using Cargo.Domain.Common;
using Cargo.Domain.HandlingEvents;

namespace Cargo.Domain.Cargos;

public class DeliveryHistory : IEntity
{
    // Identity will come from it's parent (Cargo)

    public Cargo Cargo { get; private set; }

    public List<HandlingEvent> EventHistory { get; private set; }

    public DeliveryHistory(Cargo cargo)
    {
        Cargo = cargo;
    }
}
