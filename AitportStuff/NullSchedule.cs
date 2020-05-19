namespace AitportStuff
{
    public class NullSchedule : ISchedule
    {
        /// <inheritdoc />
        public Flight? ScheduledFlight { get; } = null;

        /// <inheritdoc />
        public string Output()
        {
            return "not scheduled";
        }
    }
}
