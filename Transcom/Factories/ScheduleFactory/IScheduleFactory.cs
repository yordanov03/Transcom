namespace Transcom.Factories.ScheduleFactory
{
    public interface IScheduleFactory : IFactory
    {

        IScheduleFactory WithSequenceNumber(string sequenceNumber);
        IScheduleFactory WithTrainNumber(string trainNumber);
        IScheduleFactory WithLoctionCode(string locationCode);
        IScheduleFactory WithArrivalTime(string arrivalTime);
        IScheduleFactory WithDepartureTime(string departureTime);

    }
}
