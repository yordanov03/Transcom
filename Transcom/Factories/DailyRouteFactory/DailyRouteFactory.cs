using PSITranscom.Models;

namespace PSITranscom.Factories
{
    public class DailyRouteFactory : IDailyRouteFactory
    {
        private string dailyRunningCode;
        private string runningDate;

        public IDailyRouteFactory WithRunningDailyCode(string dailyRunningCode)
        {
            this.dailyRunningCode = dailyRunningCode;
            return this;
        }

        public IDailyRouteFactory WithRunningDate(string runningDate)
        {
            this.runningDate = runningDate;
            return this;
        }

        public DailyRoute Build() => new DailyRoute(dailyRunningCode, runningDate);
        
    }
}
