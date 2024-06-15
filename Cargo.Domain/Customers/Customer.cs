using Cargo.Domain.Common;

namespace Cargo.Domain.Customers;

public class Customer : IAggregateRoot
{
    /// <summary>
    /// Provided from External System
    /// </summary>
    public Guid CustomerId { get; private set; }

    public string Name { get; private set; }
}
