using System.Collections.Generic;

namespace AitportStuff
{
    public interface IScheduler
    {
        void AssignSchedules(List<Order> _orders, List<Flight> _flights);
    }
}
