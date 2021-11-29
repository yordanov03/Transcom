namespace Transcom.Factories
{
    public interface IDailyRouteFactory : IFactory
    {
        IDailyRouteFactory WithRunningDailyCode(string dailyRunningCode);
        IDailyRouteFactory WithRunningDate(string runningDate);

    }
}
