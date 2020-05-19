using System.Collections.Generic;
using System.Linq;

namespace AitportStuff
{
    public static class LocationExtensions
    {
        public static Location CodeSelect(this IEnumerable<Location> locations, string code)
        {
            return locations.First(_location => _location.Code == code);
        }
    }
}
