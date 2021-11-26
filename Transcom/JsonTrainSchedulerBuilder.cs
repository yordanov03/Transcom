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

            foreach (var timetable in timetables)
            {
                var selectedSchedule = schedule.Where(s => s.TrainNumber == timetable.TrainNumber).OrderBy(s=>s.SequenceNumber).ToList();
                var selectedRunningDays = runningDay.Where(rd => rd.RunningDayCode == timetable.RunningCode).ToList();

                var trainScheduleCompraised = new TrainScheduleDto(
                    timetable.TrainNumber,
                    timetable.ValidFrom,
                    timetable.ValidTo,
                    selectedSchedule);

                trainSchedules.Add(trainScheduleCompraised);
            }

            return trainSchedules;
        }
    }
}
