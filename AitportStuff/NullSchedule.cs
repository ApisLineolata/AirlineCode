namespace AitportStuff
{
    public class NullSchedule : ISchedule
    {
        /// <inheritdoc />
        public string Output()
        {
            return "Not scheduled";
        }
    }
}
