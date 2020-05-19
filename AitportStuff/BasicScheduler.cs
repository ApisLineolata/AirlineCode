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

            _orders.First().Schedule = new BasicSchedule(_flights.First());
        }
    }
}
