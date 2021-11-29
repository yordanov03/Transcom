namespace Transcom.Factories.ScheduleFactory
{
    public interface ITimetableFactory : IFactory
    {

        ITimetableFactory WithSequenceNumber(string sequenceNumber);
        ITimetableFactory WithTrainNumber(string trainNumber);
        ITimetableFactory WithLoctionCode(string locationCode);
        ITimetableFactory WithArrivalTime(string arrivalTime);
        ITimetableFactory WithDepartureTime(string departureTime);

    }
}
