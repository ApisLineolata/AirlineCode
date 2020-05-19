namespace AitportStuff
{
    public class NullSchedule : ISchedule
    {
        /// <inheritdoc />
        public string Output()
        {
            return "not scheduled";
        }
    }
}
