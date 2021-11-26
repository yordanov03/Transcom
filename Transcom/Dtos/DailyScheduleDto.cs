namespace Transcom.Dtos
{
    public class DailyScheduleDto
    {
        public DailyScheduleDto(
            int sequenceNumber,
            string locationCode,
            string arrivalTime,
            string departureTime,
            string runningDate)
        {
            this.SequenceNumber = sequenceNumber;
            this.LocationCode = locationCode;
            this.ArrivalTime = arrivalTime;
            this.DepartureTime = departureTime;
            this.RunningDate = runningDate;
        }
        public string RunningDate { get; set; }

        public int SequenceNumber { get; set; }

        public string LocationCode { get; set; }

        public string ArrivalTime { get; set; }

        public string DepartureTime { get; set; }
    }
}
