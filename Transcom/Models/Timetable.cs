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
        public string SequenceNumber { get; set; }

        public string TrainNumber { get; set; }

        public string LocationCode { get; set; }

        public string ArrivalTime { get; set; }

        public string DepartureTime { get; set; }
    }
}
