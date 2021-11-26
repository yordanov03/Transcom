using PSITranscom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transcom.Factories.ScheduleFactory
{
    internal class ScheduleFactory : IScheduleFactory
    {
        private string sequenceNumber;
        private string trainNumber;
        private string locationCode;
        private string arrivalTime;
        private string departureTime;

        public IScheduleFactory WithArrivalTime(string arrivalTime)
        {
            this.arrivalTime = arrivalTime;
            return this;
        }

        public IScheduleFactory WithDepartureTime(string departureTime)
        {
            this.departureTime = departureTime;
            return this;
        }

        public IScheduleFactory WithLoctionCode(string locationCode)
        {
            this.locationCode = locationCode;
            return this;
        }

        public IScheduleFactory WithSequenceNumber(string sequenceNumber)
        {
            this.sequenceNumber = sequenceNumber;
            return this;
        }

        public IScheduleFactory WithTrainNumber(string trainNumber)
        {
            this.trainNumber = trainNumber;
            return this;
        }
        public object Build() => new Schedule(
            sequenceNumber,
            trainNumber,
            locationCode,
            arrivalTime,
            departureTime);
        
    }
}
