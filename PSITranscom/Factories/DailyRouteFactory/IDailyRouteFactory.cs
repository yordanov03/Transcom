using PSITranscom.Models;

namespace PSITranscom.Factories
{
    public interface IDailyRouteFactory : IFactory<DailyRoute>
    {
        IDailyRouteFactory WithRunningDailyCode(string dailyRunningCode);
        IDailyRouteFactory WithRunningDate(string runningDate);

    }
}
