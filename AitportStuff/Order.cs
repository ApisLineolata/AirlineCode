using System.Collections.Generic;

namespace AitportStuff
{
    public class Order
    {
        public Order(Location _origin, Location _destination, Priority _deliveryPriority)
        {
            Origin = _origin;
            Destination = _destination;
            DeliveryPriority = _deliveryPriority;
        }

        public static IComparer<Order> DeliveryPriorityComparer { get; } = new DeliveryPriorityRelationalComparer();

        public Location Origin { get; }
        public Location Destination { get; }
        public Priority DeliveryPriority { get; }

        public ISchedule Schedule { get; set; } = new NullSchedule();

        private sealed class DeliveryPriorityRelationalComparer : IComparer<Order>
        {
            public int Compare(Order x, Order y)
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

                return x.DeliveryPriority.CompareTo(y.DeliveryPriority);
            }
        }
    }
}
