using System.Collections.Generic;
using System.Linq;

namespace AitportStuff
{
    public class BasicScheduler : IScheduler
    {
        /// <inheritdoc />
        public void AssignSchedules(List<Order> _orders, List<Flight> _flights)
        {
            if (!_orders.Any() || !_flights.Any())
            {
                return;
            }

            SortedDictionary<Flight, int> assignedCountFlights;
            assignedCountFlights = CreateCapacityCountedDictionary(_flights);
            List<Order> sortedOrders = new List<Order>(_orders);
            sortedOrders.Sort(Order.DeliveryPriorityComparer);
            sortedOrders.Reverse();

            foreach (Order order in sortedOrders)
            {
                Flight? flightToSchedule = SelectFlight(order, assignedCountFlights);
                if (flightToSchedule != null)
                {
                    order.Schedule = new BasicSchedule(flightToSchedule);
                }
            }
        }

        private static SortedDictionary<Flight, int> CreateCapacityCountedDictionary(List<Flight> _flights)
        {
            SortedDictionary<Flight, int> assignedCountFlights;
            assignedCountFlights = new SortedDictionary<Flight, int>(Flight.FlightNumberComparer);
            foreach (Flight flight in _flights)
            {
                assignedCountFlights[flight] = flight.Capacity;
            }

            return assignedCountFlights;
        }

        private Flight? SelectFlight(Order _orderToAssign, SortedDictionary<Flight, int> _assignedCountFlights)
        {
            foreach (KeyValuePair<Flight, int> assignedCountFlight in _assignedCountFlights)

            {
                Flight checkedFlight = assignedCountFlight.Key;
                int remainingCapacity = assignedCountFlight.Value;
                if (remainingCapacity <= 0)
                {
                    continue;
                }

                _assignedCountFlights[checkedFlight] = --remainingCapacity;
                return checkedFlight;
            }

            return null;
        }
    }
}
