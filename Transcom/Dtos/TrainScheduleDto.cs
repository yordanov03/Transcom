using AutoMapper;
using PSITranscom.Models;
using System.Collections.Generic;
using PSITranscom.Mapper;

namespace PSITranscom.Dtos
{
    public class TrainScheduleDto : IMapFrom<Schedule>
    {
        public TrainScheduleDto()
        {

        }
        public TrainScheduleDto(
            string trainNumber,
            string validFrom,
            string validTo,
            List<ScheduledStopDto> scheduledStops)
        {
            this.TrainNumber = trainNumber;
            this.ValidTo = validTo;
            this.ValidFrom = validFrom;
            this.ScheduledStops = scheduledStops;
        }
        public string TrainNumber { get; set; }
        public string ValidFrom { get; set; }
        public string ValidTo { get; set; }
        public List<ScheduledStopDto> ScheduledStops { get; set; } = new List<ScheduledStopDto>();

    }
}
