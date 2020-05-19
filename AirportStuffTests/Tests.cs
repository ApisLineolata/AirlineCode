using AitportStuff;
using NUnit.Framework;

namespace AirportStuffTests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(1, 2, ExpectedResult = true)]
        [TestCase(2, 1, ExpectedResult = false)]
        public bool PriorityComparesMultiTest(int firstPriority, int secondPriority)
        {
            Priority first = new Priority(firstPriority);
            Priority second = new Priority(secondPriority);
            return first > second;
        }

        [Test]
        public void FlightInitialisedTest()
        {
            Location origin = new Location("YYZ", "Toronto");
            Location destination = new Location("YUL", "Montreal");
            int departureDay = 1;
            int capacity = 20;
            Flight flight = new Flight(origin, destination, departureDay, capacity);
            Assert.That(flight.Origin, Is.EqualTo(origin));
            Assert.That(flight.Destination, Is.EqualTo(destination));
            Assert.That(flight.DepartureDay, Is.EqualTo(departureDay));
            Assert.That(flight.Capacity, Is.EqualTo(capacity));
        }

        [Test]
        public void LocationInitialisedTest()
        {
            Location location = new Location("YYZ", "Toronto");
            Assert.That(location.Code, Is.EqualTo("YYZ"));
            Assert.That(location.City, Is.EqualTo("Toronto"));
        }

        [Test]
        public void OrderInitialisedTest()
        {
            Priority orderPriority = new Priority(1);
            Location origin = new Location("YYZ", "Toronto");
            Location destination = new Location("YUL", "Montreal");

            Order order = new Order(origin, destination, orderPriority);
            Assert.That(order.Origin, Is.EqualTo(origin));
            Assert.That(order.Destination, Is.EqualTo(destination));
            Assert.That(order.DeliveryPriority, Is.EqualTo(orderPriority));
        }

        [Test]
        public void PriorityComparesProperlyTest()
        {
            Priority higher = new Priority(1);
            Priority lower = new Priority(2);
            Assert.That(higher, Is.GreaterThan(lower));
        }

        [Test]
        public void ScheduleInitialisedTest()
        {
            ISchedule schedule = new NullSchedule();
            Assert.That(schedule.Output, Is.EqualTo("not scheduled"));
        }
    }
}
