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

            foreach (var trainNumber in schedule.Select(rd => rd.TrainNumber))
            {
                //Get timetable and running day code based on train number
                var trainTimetable = timetables.Where(t => t.TrainNumber == trainNumber).ToList();

                foreach (var runningCode in trainTimetable.Where(tt=>tt.RunningCode == ))
                {

                }
            }

            return trainSchedules;
        }
    }
}
