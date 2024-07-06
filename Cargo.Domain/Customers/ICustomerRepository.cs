namespace Cargo.Domain.Customers;

public interface ICustomerRepository
{
    Customer FindByCustomerId(string id);
    Customer FindByName(string name);
    Customer FindByCargoTrackingId(string name);
}
