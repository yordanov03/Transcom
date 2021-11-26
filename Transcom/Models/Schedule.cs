using System.ComponentModel.DataAnnotations;

namespace PSITranscom.Models
{
    public class Schedule
    {
        public Schedule(
            int sequenceNumber,
            int trainNumber,
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
        public int SequenceNumber { get; set; }

        public int TrainNumber { get; set; }

        public string LocationCode { get; set; }

        public string ArrivalTime { get; set; }

        public string DepartureTime { get; set; }
    }
}
