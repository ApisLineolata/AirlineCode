namespace AitportStuff
{
    public class Flight
    {
        public Flight(Location _origin, Location _destination, int _departureDay, int _capacity, int _flightNumber)
        {
            Origin = _origin;
            Destination = _destination;
            DepartureDay = _departureDay;
            Capacity = _capacity;
            FlightNumber = _flightNumber;
        }

        public Location Origin { get; }
        public Location Destination { get; }
        public int DepartureDay { get; }
        public int Capacity { get; }
        public int FlightNumber { get; }
    }
}
