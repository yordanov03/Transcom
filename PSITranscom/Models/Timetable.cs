namespace PSITranscom.Models
{
    public class Timetable
    {
        public Timetable(
            string sequenceNumber,
            string trainNumber,
            string locationCode,
            string arrivalTime,
            string departureTime)
        {
            this.SequenceNumber = sequenceNumber;
            this.TrainNumber = trainNumber;
            this.LocationCode = locationCode;
            this.ArrivalTime = arrivalTime;
            this.DepartureTime = departureTime;
        }
        public string SequenceNumber { get; }

        public string TrainNumber { get; }

        public string LocationCode { get; }

        public string ArrivalTime { get; }

        public string DepartureTime { get; }
    }
}
