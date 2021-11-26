namespace Transcom.Dtos
{
    public class DailyScheduleDto
    {
        public DailyScheduleDto(
            string sequenceNumber,
            string locationCode,
            string arrivalTime,
            string departureTime)
        {
            this.SequenceNumber = sequenceNumber;
            this.LocationCode = locationCode;
            this.ArrivalTime = arrivalTime;
            this.DepartureTime = departureTime;
        }

        public string SequenceNumber { get; set; }

        public string LocationCode { get; set; }

        public string ArrivalTime { get; set; }

        public string DepartureTime { get; set; }
    }
}
