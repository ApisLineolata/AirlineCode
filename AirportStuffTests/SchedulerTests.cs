using System.Collections.Generic;
using AitportStuff;
using NUnit.Framework;

namespace AirportStuffTests
{
    [TestFixture]
    public class SchedulerTests
    {
        [Test]
        public void SchedulerAcceptsGivenSchedules()
        {
            IScheduler scheduler = new BasicScheduler();
            List<Order> orders = new List<Order>();
            List<Flight> flights = new List<Flight>();
            scheduler.AssignSchedules(orders, flights);
            Assert.That(orders, Is.All.Property("Schedule").Not.Null);
        }
    }
}
