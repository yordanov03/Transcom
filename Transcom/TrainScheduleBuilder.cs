using AutoMapper;
using PSITranscom.Models;
using System.Collections.Generic;
using System.Linq;
using Transcom.Dtos;

namespace Transcom
{
    public class TrainScheduleBuilder : ITrainScheduleBuilder
    {
        private readonly IMapper _mapper;

        public TrainScheduleBuilder(IMapper mapper)
        {
            this._mapper = mapper;   
        }
        public List<TrainScheduleDto> BuildTrainSchedule(
            List<Schedule> timetables,
            List<DailyRoute> runningDay,
            List<Timetable> schedule
            )
        {

            var trainSchedules = new List<TrainScheduleDto>();

            foreach (var timetable in timetables)
            {
                var selectedSchedule = schedule.Where(s => s.TrainNumber == timetable.TrainNumber).OrderBy(s => s.SequenceNumber).ToList();
                var selectedRunningDays = runningDay.Where(rd => rd.RunningDayCode == timetable.RunningCode).ToList();
                var projectedSelectedRunningDays = this._mapper.Map<List<ScheduledStopDto>>(selectedRunningDays);

                var trainScheduleCompraised = new TrainScheduleDto(
                    timetable.TrainNumber,
                    timetable.ValidFrom,
                    timetable.ValidTo,
                    projectedSelectedRunningDays);

                trainSchedules.Add(trainScheduleCompraised);
            }

            return trainSchedules;
        }
    }
}
