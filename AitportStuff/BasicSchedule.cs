namespace AitportStuff
{
    public class BasicSchedule : ISchedule
    {
        private readonly Flight assignedFlight;

        public BasicSchedule(Flight _assignedFlight)
        {
            assignedFlight = _assignedFlight;
        }

        /// <inheritdoc />
        public string Output()
        {
            return $"flightNumber: {assignedFlight.FlightNumber}";
        }
    }
}
