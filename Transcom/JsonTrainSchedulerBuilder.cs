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
            List<TimeTable> timetables,
            List<RunningDay> runningDay,
            List<Schedule> schedule
            )
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

            foreach (var timetable in timetables)
            {
                var selectedSchedule = schedule.Where(s => s.TrainNumber == timetable.TrainNumber).ToList();
                var selectedRunningDays = runningDay.Where(rd => rd.RunningDayCode == timetable.RunningCode).ToList();
            }

            return trainSchedules;
        }
    }
}
