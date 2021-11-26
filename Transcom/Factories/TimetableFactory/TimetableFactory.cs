using PSITranscom.Models;
using System;

namespace Transcom.Factories.TimetableFactory
{
    internal class TimetableFactory : ITimetableFactory
    {
        private string validFrom;
        private string runningCode;
        private string validTo;
        private string trainNumber;

        public ITimetableFactory WithRunningCode(string runningCode)
        {
            this.runningCode = runningCode;
            return this;
        }

        public ITimetableFactory WithTrainNumber(string trainNumber)
        {
            this.trainNumber = trainNumber;
            return this;
        }

        public ITimetableFactory WithValidFrom(string validFrom)
        {
            this.validFrom = validFrom;
            return this;
        }

        public ITimetableFactory WithValidTo(string validTo)
        {
            this.validTo = validTo;
            return this;
        }

        public object Build() => new TimeTable(
            validFrom,
            runningCode,
            validTo,
            trainNumber);
        
    }
}
