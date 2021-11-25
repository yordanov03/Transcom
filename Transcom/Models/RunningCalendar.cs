using System;

namespace PSITranscom.Models
{
    public class RunningCalendar
    {
        public RunningCalendar(
            int runningDayCode,
            DateTime runningDate)
        {
            this.RunningDayCode = runningDayCode;
            this.RunningDate = runningDate;
        }
        public int RunningDayCode { get; set; }
        public DateTime RunningDate { get; set; }

    }
}
