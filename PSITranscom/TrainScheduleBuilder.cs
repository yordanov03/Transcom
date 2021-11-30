using AutoMapper;
using PSITranscom.Models;
using System.Collections.Generic;
using System.Linq;
using PSITranscom.Dtos;

namespace PSITranscom
{
    public class TrainScheduleBuilder : ITrainScheduleBuilder
    {
        private readonly IMapper _mapper;

        public TrainScheduleBuilder(IMapper mapper)
        {
            this._mapper = mapper;   
        }
        public List<TrainScheduleDto> BuildTrainSchedule(
            List<Schedule> schedules,
            List<DailyRoute> dailyRoute,
            List<Timetable> timetables
            )
        {

            var trainSchedules = new List<TrainScheduleDto>();

            foreach (var schedule in schedules)
            {
                var selectedTimetable = timetables.Where(s => s.TrainNumber == schedule.TrainNumber).OrderBy(s => s.SequenceNumber).ToList();
                var selectedDailyRoute = dailyRoute.Where(rd => rd.RunningDayCode == schedule.RunningCode).ToList();

                var mappedTrainSchedule = this._mapper.Map<Schedule, TrainScheduleDto>(schedule);
                var mappedTimetable = this._mapper.Map<List<Timetable>,List<ScheduledStopDto>>(selectedTimetable);

                mappedTrainSchedule.ScheduledStops = mappedTimetable;

                trainSchedules.Add(mappedTrainSchedule);
            }

            return trainSchedules;
        }
    }
}
