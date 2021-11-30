using PSITranscom.Models;

namespace PSITranscom.Factories.ScheduleFactory
{
    public class TimetableFactory : ITimetableFactory
    {
        private string sequenceNumber;
        private string trainNumber;
        private string locationCode;
        private string arrivalTime;
        private string departureTime;

        public ITimetableFactory WithArrivalTime(string arrivalTime)
        {
            this.arrivalTime = arrivalTime;
            return this;
        }

        public ITimetableFactory WithDepartureTime(string departureTime)
        {
            this.departureTime = departureTime;
            return this;
        }

        public ITimetableFactory WithLoctionCode(string locationCode)
        {
            this.locationCode = locationCode;
            return this;
        }

        public ITimetableFactory WithSequenceNumber(string sequenceNumber)
        {
            this.sequenceNumber = sequenceNumber;
            return this;
        }

        public ITimetableFactory WithTrainNumber(string trainNumber)
        {
            this.trainNumber = trainNumber;
            return this;
        }
        public Timetable Build() => new Timetable(
            sequenceNumber,
            trainNumber,
            locationCode,
            arrivalTime,
            departureTime);

    }
}
