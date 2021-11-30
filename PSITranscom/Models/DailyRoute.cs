namespace PSITranscom.Models
{
    public class DailyRoute
    {
        public DailyRoute(
            string runningDayCode,
            string runningDate)
        {
            this.RunningDayCode = runningDayCode;
            this.RunningDate = runningDate;
        }
        public string RunningDayCode { get; }
        public string RunningDate { get; }

    }
}
