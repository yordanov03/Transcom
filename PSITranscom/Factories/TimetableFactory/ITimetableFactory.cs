using PSITranscom.Models;

namespace PSITranscom.Factories.ScheduleFactory
{
    public interface ITimetableFactory : IFactory<Timetable>
    {

        ITimetableFactory WithSequenceNumber(string sequenceNumber);
        ITimetableFactory WithTrainNumber(string trainNumber);
        ITimetableFactory WithLoctionCode(string locationCode);
        ITimetableFactory WithArrivalTime(string arrivalTime);
        ITimetableFactory WithDepartureTime(string departureTime);

    }
}
