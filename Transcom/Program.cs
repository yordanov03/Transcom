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
            var runningCalendar = FileReader.ImportRunningCalendarFromFile();
            var runningDays = FileReader.ImportRunningDayFromFile();
            var timeTable = FileReader.ImportTimeTableFromFile();

            var parsedRunningDays = RunningDayParser.Parse(runningDays);
            var parsedRunningCalendar = RunningCalendarParser.Parse(runningCalendar, parsedRunningDays.Select(d=>d.RunningCode).Distinct().ToArray());
            var parsedTimetable = TimeTableParser.Parse(timeTable, parsedRunningDays.Select(d=>d.TrainNumber).ToArray());



            var fileBuilder = new JsonFileCreator();
            fileBuilder.CreateJsonFile(parsedRunningCalendar, "somename");

            Console.WriteLine("fuck");
        }
    }
}
