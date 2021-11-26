using Newtonsoft.Json;
using PSITranscom;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using Transcom.Parsers;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Transcom
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var timetable = FileReader.ImportTimetableFromFile();
            var runningDays = FileReader.ImportRunningDaysFromFile();
            var schedule = FileReader.ImportScheduleFromFile();

            var parsedTimetable = RunningDayParser.Parse(timetable);
            var parsedRunningDays = RunningCalendarParser.Parse(runningDays, parsedTimetable.Select(d=>d.RunningCode).Distinct().ToArray());
            var parsedSchedule = TimeTableParser.Parse(timetable, parsedTimetable.Select(d=>d.TrainNumber).ToArray());

            var scheduleBuilder = new JsonTrainSchedulerBuilder();
            scheduleBuilder.BuildObject(parsedTimetable, parsedRunningDays, parsedSchedule);


            var fileBuilder = new JsonFileCreator();
            fileBuilder.CreateJsonFile(parsedTimetable, "somename");

            Console.WriteLine("fuck");
        }
    }
}
