using Newtonsoft.Json;
using PSITranscom;
using System;
using System.IO;
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

            var parsedRunningCalendar = RunningCalendarParser.Parse(runningCalendar);
            var parsedRunningDays = RunningDayParser.Parse(runningDays, );
            var parsedTimetable = TimeTableParser.Parse(timeTable);



            var fileBuilder = new JsonFileBuilder();
            fileBuilder.CreateJsonFile(parsedRunningCalendar, "somename");

            Console.WriteLine("fuck");
        }
    }
}
