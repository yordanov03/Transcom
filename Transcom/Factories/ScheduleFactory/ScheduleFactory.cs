using PSITranscom.Models;

namespace Transcom.Factories.TimetableFactory
{
    public class ScheduleFactory : IScheduleFactory
    {
        private string validFrom;
        private string runningCode;
        private string validTo;
        private string trainNumber;

        public IScheduleFactory WithRunningCode(string runningCode)
        {
            this.runningCode = runningCode;
            return this;
        }

        public IScheduleFactory WithTrainNumber(string trainNumber)
        {
            this.trainNumber = trainNumber;
            return this;
        }

        public IScheduleFactory WithValidFrom(string validFrom)
        {
            this.validFrom = validFrom;
            return this;
        }

        public IScheduleFactory WithValidTo(string validTo)
        {
            this.validTo = validTo;
            return this;
        }

        public Schedule Build() => new Schedule(
            validFrom,
            runningCode,
            validTo,
            trainNumber);

    }
}
