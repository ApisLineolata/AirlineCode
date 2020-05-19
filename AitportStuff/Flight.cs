namespace AitportStuff
{
    public class Flight
    {
        public Flight(Location _origin, Location _destination, int _departureDay, int _capacity)
        {
            Origin = _origin;
            Destination = _destination;
            DepartureDay = _departureDay;
            Capacity = _capacity;
        }

        public Location Origin { get; }
        public Location Destination { get; }
        public int DepartureDay { get; }
        public int Capacity { get; }
    }
}
