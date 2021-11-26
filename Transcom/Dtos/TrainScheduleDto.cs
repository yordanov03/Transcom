using System.Collections.Generic;

namespace Transcom.Dtos
{
    public class TrainScheduleDto
    {
        public TrainScheduleDto(
            string trainNumber,
            string validFrom,
            string validTo,
            Dictionary<string, List<DailyScheduleDto>> dailySchedules)
        {
            this.TrainNumber = trainNumber;
            this.ValidTo = validTo;
            this.ValidFrom = validFrom;
            this.DailySchedules = new Dictionary<string, DailyScheduleDto>();
        }
        public string TrainNumber { get; set; }
        public string ValidFrom { get; set; }
        public string ValidTo { get; set; }
        public Dictionary<string, DailyScheduleDto> DailySchedules { get; set; }
    }
}
