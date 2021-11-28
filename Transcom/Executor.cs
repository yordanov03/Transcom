using AutoMapper;
using PSITranscom;
using System.Linq;
using Transcom.Parsers;

namespace Transcom
{
    public class Executor
    {
        private readonly IMapper _mapper;
        private readonly IFileReader _fileReader;

        public Executor(
            IMapper mapper,
            IFileReader fileReader)
        {
            this._mapper = mapper;
            this._fileReader = fileReader;
        }

        public void Execute()
        {
            var fileData = this._fileReader.ImportFiles();

            var schedule = fileData[2];
            var dailyRoute = fileData[0];
            var timetable = fileData[1];



            //var parsedSchedule = ScheduleParser.Parse(schedule);

            ////Getting only the daily route that matches the running code
            //var parsedDailyRoute = DailyRouteParser.Parse(dailyRoute, parsedSchedule.Select(d => d.RunningCode).Distinct().ToArray());
            //var parsedTimetable = TimetableParser.Parse(dailyRoute, parsedSchedule.Select(d => d.TrainNumber).ToArray());

            //var scheduleBuilder = new JsonTrainSchedulerBuilder(_mapper);
            //var schedulePerTrain = scheduleBuilder.BuildObject(parsedSchedule, parsedDailyRoute, parsedTimetable);


            //var fileBuilder = new JsonFileCreator();
            //fileBuilder.CreateJsonFile(schedulePerTrain);
        }
    }
}
