namespace Transcom.Factories.ScheduleFactory
{
    public interface ISchedule1Factory : IFactory
    {

        ISchedule1Factory WithSequenceNumber(string sequenceNumber);
        ISchedule1Factory WithTrainNumber(string trainNumber);
        ISchedule1Factory WithLoctionCode(string locationCode);
        ISchedule1Factory WithArrivalTime(string arrivalTime);
        ISchedule1Factory WithDepartureTime(string departureTime);

    }
}
