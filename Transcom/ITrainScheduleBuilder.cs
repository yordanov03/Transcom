using PSITranscom.Models;
using System.Collections.Generic;
using Transcom.Dtos;

namespace Transcom
{
    public interface ITrainScheduleBuilder
    {
        List<TrainScheduleDto> BuildTrainSchedule(List<Schedule> timetables,
            List<DailyRoute> runningDay,
            List<Timetable> schedule);
    }
}
