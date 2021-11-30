using PSITranscom.Models;

namespace Transcom.Factories
{
    public interface IDailyRouteFactory : IFactory<DailyRoute>
    {
        IDailyRouteFactory WithRunningDailyCode(string dailyRunningCode);
        IDailyRouteFactory WithRunningDate(string runningDate);

    }
}
