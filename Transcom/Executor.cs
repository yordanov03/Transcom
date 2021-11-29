using AutoMapper;
using PSITranscom;
using PSITranscom.Models;
using System.Linq;
using Transcom.Parsers;

namespace Transcom
{
    public class Executor
    {
        private readonly IMapper _mapper;
        private readonly IFileReader _fileReader;
        private readonly IScheduleParser _scheduleParser;
        private readonly IParser<DailyRoute> _dailyRouteParser;
        private readonly IParser<Timetable> _timetableParser;
        private readonly ITrainScheduleBuilder _trainScheduleBuilder;
        private readonly IJsonFileCreator _jsonFileCreator;

        public Executor(
            IMapper mapper,
            IFileReader fileReader,
            IScheduleParser scheduleParser,
            IParser<DailyRoute> dailyRouteParser,
            IParser<Timetable> timetableParser,
            ITrainScheduleBuilder trainScheduleBuilder,
            IJsonFileCreator jsonFileCreator)
        {
            this._mapper = mapper;
            this._fileReader = fileReader;
            this._scheduleParser = scheduleParser;
            this._dailyRouteParser = dailyRouteParser;
            this._timetableParser = timetableParser;
            this._trainScheduleBuilder = trainScheduleBuilder;
            this._jsonFileCreator = jsonFileCreator;
        }

        public void Execute()
        {
            var fileData = this._fileReader.ImportFiles();

            var schedule = fileData[2];
            var dailyRoute = fileData[0];
            var timetable = fileData[1];

            var parsedSchedule = this._scheduleParser.ParseSchedule(schedule);

            ////Getting only the daily route that matches the running code
            var parsedDailyRoute = this._dailyRouteParser.ParseInput(dailyRoute, parsedSchedule.Select(d => d.RunningCode).Distinct().ToArray());
            var parsedTimetable = this._timetableParser.ParseInput(timetable, parsedSchedule.Select(d => d.TrainNumber).ToArray());

            var trainScheduleBuilder = this._trainScheduleBuilder.BuildTrainSchedule(parsedSchedule, parsedDailyRoute, parsedTimetable);

            this._jsonFileCreator.CreateJsonFile(trainScheduleBuilder);
        }
    }
}
