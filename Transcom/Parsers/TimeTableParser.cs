using PSITranscom.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static Transcom.Constants;

namespace Transcom.Parsers
{
    public class TimeTableParser
    {
        public static List<Schedule> Parse(string[] timeTableInput, int[] trainNumbers)
        {
            var parsedTimeTables = new List<Schedule>();

            Regex rgx = new Regex(RegexPatternConstants.TimetableParserRegularExpression);

            foreach (var timetable in timeTableInput)
            {
                foreach (Match match in rgx.Matches(timetable))
                {
                    var parsedTrainNumber = int.Parse(match.Groups[2].Value);

                    foreach (var trainNumber in trainNumbers)
                    {
                        if (trainNumber == parsedTrainNumber)
                        {
                            var parsedtimetable = new Schedule(
                            int.Parse(match.Groups[1].Value),
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
