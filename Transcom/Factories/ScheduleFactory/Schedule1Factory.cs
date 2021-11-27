using PSITranscom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transcom.Factories.ScheduleFactory
{
    internal class Schedule1Factory : ISchedule1Factory
    {
        private string sequenceNumber;
        private string trainNumber;
        private string locationCode;
        private string arrivalTime;
        private string departureTime;

        public ISchedule1Factory WithArrivalTime(string arrivalTime)
        {
            this.arrivalTime = arrivalTime;
            return this;
        }

        public ISchedule1Factory WithDepartureTime(string departureTime)
        {
            this.departureTime = departureTime;
            return this;
        }

        public ISchedule1Factory WithLoctionCode(string locationCode)
        {
            this.locationCode = locationCode;
            return this;
        }

        public ISchedule1Factory WithSequenceNumber(string sequenceNumber)
        {
            this.sequenceNumber = sequenceNumber;
            return this;
        }

        public ISchedule1Factory WithTrainNumber(string trainNumber)
        {
            this.trainNumber = trainNumber;
            return this;
        }
        public object Build() => new Timetable(
            sequenceNumber,
            trainNumber,
            locationCode,
            arrivalTime,
            departureTime);
        
    }
}
