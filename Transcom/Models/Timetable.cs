using System;

namespace PSITranscom.Models
{
    public class TimeTable
    {
        public TimeTable(
            DateTime validFrom,
            int runningCode,
            DateTime validTo,
            int trainNumber)
        {
            this.ValidFrom = validFrom;
            this.RunningCode = runningCode;
            this.ValidTo = validTo;
            this.TrainNumber = trainNumber;
        }

        public DateTime ValidFrom { get; set; }
        public int RunningCode { get; set; }
        public DateTime ValidTo { get; set; }
        public int TrainNumber { get; set; }
    }
}
