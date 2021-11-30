namespace PSITranscom.Models
{
    public class Schedule
    {
        public Schedule(
            string validFrom,
            string runningCode,
            string validTo,
            string trainNumber)
        {
            this.ValidFrom = validFrom;
            this.RunningCode = runningCode;
            this.ValidTo = validTo;
            this.TrainNumber = trainNumber;
        }

        public string ValidFrom { get; }
        public string RunningCode { get; }
        public string ValidTo { get; }
        public string TrainNumber { get; }
    }
}
