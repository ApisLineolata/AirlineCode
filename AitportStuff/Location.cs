namespace AitportStuff
{
    public class Location
    {
        public Location(string _code, string _city)
        {
            City = _city;
            Code = _code;
        }

        public string City { get; }
        public string Code { get; }
    }
}
