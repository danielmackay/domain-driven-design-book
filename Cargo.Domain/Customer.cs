using Cargo.Domain.Common;

namespace Cargo.Domain;

public class Customer : IEntity
{
    /// <summary>
    /// Provided from External System
    /// </summary>
    public Guid CustomerId { get; private set; }

    public string Name { get; private set; }
}
