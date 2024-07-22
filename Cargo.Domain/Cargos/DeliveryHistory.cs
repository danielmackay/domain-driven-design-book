using Cargo.Domain.Common;

namespace Cargo.Domain.Cargos;

public class DeliveryHistory : IEntity
{
    // Identity will come from it's parent (Cargo)

    public Cargo Cargo { get; private set; }

    public DeliveryHistory(Cargo cargo)
    {
        Cargo = cargo;
    }
}
