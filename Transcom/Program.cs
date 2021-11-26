using PSITranscom;
using System;
using System.Linq;
using Transcom.Parsers;

namespace Transcom
{
    class Program
    {
        static void Main(string[] args)
        {

            var timetable = FileReader.ImportTimetableFromFile();
            var runningDays = FileReader.ImportRunningDaysFromFile();
            var schedule = FileReader.ImportScheduleFromFile();

            var parsedTimetable = TimetableParser.Parse(timetable);
            var parsedRunningDays = RunningDayParser.Parse(runningDays, parsedTimetable.Select(d => d.RunningCode).Distinct().ToArray());
            var parsedSchedule = ScheduleParser.Parse(schedule, parsedTimetable.Select(d => d.TrainNumber).ToArray());

            var scheduleBuilder = new JsonTrainSchedulerBuilder();
            var schedulePerTrain = scheduleBuilder.BuildObject(parsedTimetable, parsedRunningDays, parsedSchedule);


            var fileBuilder = new JsonFileCreator();
            fileBuilder.CreateJsonFile(schedulePerTrain);

            Console.WriteLine("fuck");
        }
    }
}
