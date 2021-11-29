using PSITranscom.Models;

namespace Transcom.Factories
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

        public object Build() => new DailyRoute(dailyRunningCode, runningDate);
        
    }
}
