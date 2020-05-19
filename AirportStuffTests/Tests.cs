using AitportStuff;
using NUnit.Framework;

namespace AirportStuffTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void LocationInitialisedTest()
        {
            Location location = new Location("YYZ", "Toronto");
            Assert.That(location.Code, Is.EqualTo("YYZ"));
            Assert.That(location.City, Is.EqualTo("Toronto"));
        }
    }
}
