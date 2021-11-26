using System;

namespace PSITranscom.Models
{
    public class RunningDay
    {
        public RunningDay(
            string runningDayCode,
            string runningDate)
        {
            this.RunningDayCode = runningDayCode;
            this.RunningDate = runningDate;
        }
        public string RunningDayCode { get; set; }
        public string RunningDate { get; set; }

    }
}
