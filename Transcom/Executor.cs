using AutoMapper;
using PSITranscom;
using System.Linq;
using Transcom.Parsers;

namespace Transcom
{
    public class Executor
    {
        private readonly IMapper _mapper;

        public Executor(IMapper mapper)
        {
            _mapper = mapper;
        }

        public void Execute()
        {
            var schedule = FileReader.ImportScheduleFromFile();
            var dailyRoute = FileReader.ImportDailyRouteFromFile();
            var timetable = FileReader.ImportTimetableFromFile();

            var parsedSchedule = ScheduleParser.Parse(schedule);

            //Getting only the daily route that matches the running code
            var parsedDailyRoute = DailyRouteParser.Parse(dailyRoute, parsedSchedule.Select(d => d.RunningCode).Distinct().ToArray());
            var parsedTimetable = TimetableParser.Parse(dailyRoute, parsedSchedule.Select(d => d.TrainNumber).ToArray());

            var scheduleBuilder = new JsonTrainSchedulerBuilder(_mapper);
            var schedulePerTrain = scheduleBuilder.BuildObject(parsedSchedule, parsedDailyRoute, parsedTimetable);


            var fileBuilder = new JsonFileCreator();
            fileBuilder.CreateJsonFile(schedulePerTrain);
        }
    }
}
