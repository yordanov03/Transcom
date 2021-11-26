using PSITranscom.Models;
using System.Collections.Generic;

namespace Transcom.Dtos
{
    public class TrainScheduleDto
    {
        public TrainScheduleDto(
            string trainNumber,
            string validFrom,
            string validTo,
            List<Schedule> scheduledStops)
        {
            this.TrainNumber = trainNumber;
            this.ValidTo = validTo;
            this.ValidFrom = validFrom;
            this.ScheduledStops = scheduledStops;
        }
        public string TrainNumber { get; set; }
        public string ValidFrom { get; set; }
        public string ValidTo { get; set; }
        public List<Schedule> ScheduledStops { get; set; } = new List<Schedule>();
    }
}
