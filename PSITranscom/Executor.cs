using AutoMapper;
using PSITranscom;
using PSITranscom.Models;
using System.Linq;
using PSITranscom.Parsers;

namespace PSITranscom
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
            //Import data
            var fileData = this._fileReader.ImportFiles();

            var schedule = fileData.ScheduleData;
            var dailyRoute = fileData.DailyRouteData;
            var timetable = fileData.TimetableData;

            //Parse the table containing trainNumber and runningCode that will allow to load only the data of interest from the other two collections
            var parsedSchedule = this._scheduleParser.ParseSchedule(schedule);

            //Importing only the daily routes that match the running code
            var parsedDailyRoute = this._dailyRouteParser.ParseInput(dailyRoute, parsedSchedule.Select(d => d.RunningCode).Distinct().ToArray());

            //Importing only timetables that match the already parsed train numbers
            var parsedTimetable = this._timetableParser.ParseInput(timetable, parsedSchedule.Select(d => d.TrainNumber).ToArray());

            //Comprise Dto data for json file
            var trainScheduleBuilder = this._trainScheduleBuilder.BuildTrainSchedule(parsedSchedule, parsedDailyRoute, parsedTimetable);

            //Create json file with the information from the dto
            this._jsonFileCreator.CreateJsonFile(trainScheduleBuilder);
        }
    }
}
