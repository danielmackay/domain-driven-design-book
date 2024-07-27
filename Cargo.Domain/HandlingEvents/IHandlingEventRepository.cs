namespace Cargo.Domain.HandlingEvents;

public interface IHandlingEventRepository
{
    IEnumerable<HandlingEvent> FindByCargoIdTimeType(string cargoId, DateTime time, string type);
    IEnumerable<HandlingEvent> FindByCargoId(string cargoId);
    IEnumerable<HandlingEvent> FindByScheuldeId(string scheduleId);
    HandlingEvent FindMostRecentByCargoIdType(string cargoId, string type);
}