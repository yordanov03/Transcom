using PSITranscom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transcom.Dtos;

namespace Transcom
{
    public class JsonTrainSchedulerBuilder
    {
        public List<TrainScheduleDto> BuildObject(
            List<Schedule> schedule,
            List<RunningDay> runningDay,
            List<TimeTable> timetables)
        {
            var trainSchedules = new List<TrainScheduleDto>();

            //foreach (var trainNumber in trainRunningDays.Select(rd=>rd.TrainNumber))
            //{
            //    var filteredTimeTable = timetable.Where(t => t.TrainNumber == trainNumber).ToList();

            //    foreach (var route in filteredTimeTable)
            //    {
            //        //var trainSchedule = new TrainSchedule(
            //        //    route.SequenceNumber,
            //        //    route.TrainNumber,
            //        //    route.LocationCode,
            //        //    route.ArrivalTime,
            //        //    route.DepartureTime);

            //        //trainSchedules.Add(trainSchedule);
            //    }


            //}

            foreach (var trainNumber in collection)
            {

            }

            return trainSchedules;
        }
    }
}
