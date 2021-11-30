using PSITranscom.Models;
using Transcom.Mapper;

namespace Transcom.Dtos
{
    public class ScheduledStopDto : IMapFrom<Timetable>
    {
        public string SequenceNumber { get; set; }

        public string LocationCode { get; set; }

        public string ArrivalTime { get; set; }

        public string DepartureTime { get; set; }
    }
}
