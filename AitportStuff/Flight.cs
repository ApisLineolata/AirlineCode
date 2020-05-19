using System.Collections.Generic;

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

        public static IComparer<Flight> FlightNumberComparer { get; } = new FlightNumberRelationalComparer();

        public Location Origin { get; }
        public Location Destination { get; }
        public int DepartureDay { get; }
        public int Capacity { get; }
        public int FlightNumber { get; }

        private sealed class FlightNumberRelationalComparer : IComparer<Flight>
        {
            public int Compare(Flight x, Flight y)
            {
                if (ReferenceEquals(x, y))
                {
                    return 0;
                }

                if (ReferenceEquals(null, y))
                {
                    return 1;
                }

                if (ReferenceEquals(null, x))
                {
                    return -1;
                }

                return x.FlightNumber.CompareTo(y.FlightNumber);
            }
        }
    }
}
