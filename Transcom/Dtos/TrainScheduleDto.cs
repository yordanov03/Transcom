﻿using AutoMapper;
using PSITranscom.Models;
using System.Collections.Generic;
using Transcom.Mapper;

namespace Transcom.Dtos
{
    public class TrainScheduleDto : IMapFrom<Schedule>
    {
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

        public void Mapping(Profile mapper)
        {
            mapper.CreateMap<Schedule, TrainScheduleDto>();
        }
    }
}
