using System.Collections.Generic;
using AitportStuff;
using NUnit.Framework;

namespace AirportStuffTests
{
    [TestFixture]
    public class SchedulerTests
    {
        private List<Location> Locations = new List<Location> {new Location("YYZ", "Toronto"), new Location("YUL", "Montreal")};

        [Test]
        public void SchedulerAcceptsGivenSchedules()
        {
            IScheduler scheduler = new BasicScheduler();
            List<Order> orders = new List<Order>();
            List<Flight> flights = new List<Flight>();
            scheduler.AssignSchedules(orders, flights);
            Assert.That(orders, Is.All.Property("Schedule").Not.Null);
        }

        [Test]
        public void SchedulerDoesNotOverBookCapacity()
        {
            IScheduler scheduler = new BasicScheduler();
            List<Order> orders = new List<Order>
            {
                new Order(Locations.CodeSelect("YUL"), Locations.CodeSelect("YYZ"), new Priority(2)),
                new Order(Locations.CodeSelect("YUL"), Locations.CodeSelect("YYZ"), new Priority(1))
            };
            int smallFlightCapacity = 1;
            Flight smallFlight = new Flight(Locations.CodeSelect("YUL"), Locations.CodeSelect("YYZ"), 1, smallFlightCapacity, 1);
            List<Flight> flights = new List<Flight> {smallFlight, new Flight(Locations.CodeSelect("YUL"), Locations.CodeSelect("YYZ"), 2, 20, 2)};

            scheduler.AssignSchedules(orders, flights);

            Assert.That(orders.FindAll(_order => _order.Schedule.ScheduledFlight == smallFlight), Has.Count.LessThanOrEqualTo(smallFlightCapacity));
        }

        [Test]
        public void SchedulerSchedulesMultiOrderNotNull()
        {
            IScheduler scheduler = new BasicScheduler();
            List<Order> orders = new List<Order>
            {
                new Order(Locations.CodeSelect("YUL"), Locations.CodeSelect("YYZ"), new Priority(2)),
                new Order(Locations.CodeSelect("YUL"), Locations.CodeSelect("YYZ"), new Priority(1))
            };
            List<Flight> flights = new List<Flight> {new Flight(Locations.CodeSelect("YUL"), Locations.CodeSelect("YYZ"), 1, 20, 1)};

            scheduler.AssignSchedules(orders, flights);
            Assert.That(orders, Is.All.Property("Schedule").Not.TypeOf<NullSchedule>());
        }

        [Test]
        public void SchedulerSchedulesSingleOrder()
        {
            IScheduler scheduler = new BasicScheduler();
            List<Order> orders = new List<Order> {new Order(Locations.CodeSelect("YUL"), Locations.CodeSelect("YYZ"), new Priority(1))};
            List<Flight> flights = new List<Flight> {new Flight(Locations.CodeSelect("YUL"), Locations.CodeSelect("YYZ"), 1, 20, 1)};

            scheduler.AssignSchedules(orders, flights);
            Assert.That(orders, Is.All.Property("Schedule").Not.Null);
        }

        [Test]
        public void SchedulerSchedulesSingleOrderNotNull()
        {
            IScheduler scheduler = new BasicScheduler();
            List<Order> orders = new List<Order> {new Order(Locations.CodeSelect("YUL"), Locations.CodeSelect("YYZ"), new Priority(1))};
            List<Flight> flights = new List<Flight> {new Flight(Locations.CodeSelect("YUL"), Locations.CodeSelect("YYZ"), 1, 20, 1)};

            scheduler.AssignSchedules(orders, flights);
            Assert.That(orders, Is.All.Property("Schedule").Not.TypeOf<NullSchedule>());
        }
    }
}
