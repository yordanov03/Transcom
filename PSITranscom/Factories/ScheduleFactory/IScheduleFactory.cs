using PSITranscom.Models;

namespace PSITranscom.Factories.TimetableFactory
{
    public interface IScheduleFactory : IFactory<Schedule>
    {
        IScheduleFactory WithValidFrom(string validFrom);
        IScheduleFactory WithRunningCode(string runningCode);
        IScheduleFactory WithValidTo(string validTo);
        IScheduleFactory WithTrainNumber(string trainNumber);
    }
}
