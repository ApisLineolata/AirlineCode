using System;

namespace AitportStuff
{
    public class Flight
    {
        public Flight(Location _origin, Location _destination, DateTime _departure, int _capacity)
        {
            Origin = _origin;
            Destination = _destination;
            Departure = _departure;
            Capacity = _capacity;
        }

        public Location Origin { get; }
        public Location Destination { get; }
        public DateTime Departure { get; }
        public int Capacity { get; }
    }
}
