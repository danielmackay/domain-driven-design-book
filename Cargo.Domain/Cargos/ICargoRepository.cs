namespace Cargo.Domain.Cargos;

public interface ICargoRepository
{
    Cargo FindByCargoTrackingId(string id);
}
