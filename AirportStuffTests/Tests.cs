using System;
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
            DateTime departure = new DateTime(2020, 01, 01, 12, 0, 0);
            int capacity = 20;
            Flight flight = new Flight(origin, destination, departure, capacity);
            Assert.That(flight.Origin, Is.EqualTo(origin));
            Assert.That(flight.Destination, Is.EqualTo(destination));
            Assert.That(flight.Departure, Is.EqualTo(departure));
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

            // Order order = new Order(); 
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
            ISchedule schedule = new PseudoSchedule(1);
            Assert.That(schedule.Output, Is.EqualTo("day: 1"));
        }
    }

    public class PseudoSchedule : ISchedule
    {
        private readonly int m_day;

        public PseudoSchedule(int _day)
        {
            m_day = _day;
        }

        /// <inheritdoc />
        public string Output()
        {
            return $"day: {m_day}";
        }
    }
}
