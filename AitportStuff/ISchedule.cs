namespace AitportStuff
{
    public interface ISchedule
    {
        Flight? ScheduledFlight { get; }
        string Output();
    }
}
