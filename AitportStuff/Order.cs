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

        public Location Origin { get; }
        public Location Destination { get; }
        public Priority DeliveryPriority { get; }

        public ISchedule Schedule { get; set; } = new NullSchedule();
    }
}
