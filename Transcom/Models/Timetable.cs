using System.ComponentModel.DataAnnotations;

namespace PSITranscom.Models
{
    public class Timetable
    {
        public Timetable(
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
        [MinLength(1)]
        [MaxLength(5)]
        public int SequenceNumber { get; set; }
        [MinLength(1)]
        [MaxLength(4)]
        public int TrainNumber { get; set; }
        [MinLength(1)]
        [MaxLength(5)]
        public string LocationCode { get; set; }
        [MinLength(1)]
        [MaxLength(4)]
        public string ArrivalTime { get; set; }
        [MinLength(1)]
        [MaxLength(5)]
        public string DepartureTime { get; set; }
    }
}
