using AutoMapper;
using PSITranscom;
using System.Linq;
using Transcom.Parsers;

namespace Transcom
{
    public static class Executor
    {
        public static void Execute()
        {
            var timetable = FileReader.ImportTimetableFromFile();
            var runningDays = FileReader.ImportRunningDaysFromFile();
            var schedule = FileReader.ImportScheduleFromFile();

            var parsedTimetable = TimetableParser.Parse(timetable);

            //Getting only the daily route that matches the running code
            var parsedRunningDays = RunningDayParser.Parse(runningDays, parsedTimetable.Select(d => d.RunningCode).Distinct().ToArray());
            var parsedSchedule = ScheduleParser.Parse(schedule, parsedTimetable.Select(d => d.TrainNumber).ToArray());

            var scheduleBuilder = new JsonTrainSchedulerBuilder();
            var schedulePerTrain = scheduleBuilder.BuildObject(parsedTimetable, parsedRunningDays, parsedSchedule);


            var fileBuilder = new JsonFileCreator();
            fileBuilder.CreateJsonFile(schedulePerTrain);
        }
    }
}
