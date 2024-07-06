namespace Cargo.Domain.Locations;

public interface ILocationRepository
{
    Location FindByPortCode(string portCode);
    Location FindByCityName(string name);
}
