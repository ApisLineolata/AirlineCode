using System;
using AitportStuff;
using NUnit.Framework;

namespace AirportStuffTests
{
    [TestFixture]
    public class Tests
    {
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
    }
}
