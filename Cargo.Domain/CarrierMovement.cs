namespace Cargo.Domain;

public class CarrierMovement
{
    public Guid ScheduleId { get; private set; }

    public Location From { get; private set; }

    public Location To { get; private set; }
}
