using PSITranscom.Models;
using System.Collections.Generic;
using PSITranscom.Dtos;

namespace PSITranscom
{
    public interface ITrainScheduleBuilder
    {
        List<TrainScheduleDto> BuildTrainSchedule(
            List<Schedule> timetables,
            List<DailyRoute> runningDay,
            List<Timetable> schedule);
    }
}
