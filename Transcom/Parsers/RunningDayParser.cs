using PSITranscom.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static Transcom.Constants;

namespace Transcom.Parsers
{
    public static class RunningDayParser
    {

        public static List<TrainRunningDay> Parse(string[] runningDaysInput)
        {
            var runningDays = new List<TrainRunningDay>();
            var dateParser = new DateParser();

            Regex rgx = new Regex(RegexPatternConstants.DayParserRegexExpression);

            foreach (var day in runningDaysInput)
            {
                foreach (Match match in rgx.Matches(day))
                {
                    var runningDay = new TrainRunningDay(
                       dateParser.ParseDate(match.Groups[1].Value),
                       int.Parse(match.Groups[2].Value),
                       dateParser.ParseDate(match.Groups[3].Value),
                       int.Parse(match.Groups[4].Value));
                    runningDays.Add(runningDay);
                }
            }

            return runningDays;
        }
    }
}
