using PSITranscom.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static Transcom.Constants;

namespace Transcom.Parsers
{
    public class ScheduleParser
    {
        public static List<Schedule> Parse(string[] timeTableInput, string[] trainNumbers)
        {
            var parsedTimeTables = new List<Schedule>();

            Regex rgx = new Regex(RegexPatternConstants.ScheduleParserRegularExpression);

            foreach (var timetable in timeTableInput)
            {
                foreach (Match match in rgx.Matches(timetable))
                {
                    var parsedTrainNumber = match.Groups[2].Value;

                    foreach (var trainNumber in trainNumbers)
                    {
                        if (trainNumber == parsedTrainNumber)
                        {
                            var parsedtimetable = new Schedule(
                            match.Groups[1].Value,
                            parsedTrainNumber,
                            match.Groups[3].Value,
                            match.Groups[4].Value,
                            match.Groups[5].Value);

                            parsedTimeTables.Add(parsedtimetable);
                        }
                    }
                }
            }

            return parsedTimeTables;
        }
    }
}
