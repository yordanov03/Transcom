using System;
using System.Collections.Generic;

namespace Transcom.Dtos
{
    public class TrainScheduleDto
    {
        public string TrainNumber { get; set; }
        public string ValidFrom { get; set; }
        public string ValidTo { get; set; }
        public Dictionary<string,DailyScheduleDto> DailySchedules { get; set; }
    }
}
