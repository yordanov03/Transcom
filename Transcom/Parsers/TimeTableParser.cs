using PSITranscom.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static Transcom.Constants;

namespace Transcom.Parsers
{
    public static class TimetableParser
    {

        public static List<TimeTable> Parse(string[] runningDaysInput)
        {
            var runningDays = new List<TimeTable>();

            Regex rgx = new Regex(RegexPatternConstants.TimetableParserRegexExpression);

            foreach (var day in runningDaysInput)
            {
                foreach (Match match in rgx.Matches(day))
                {
                    var runningDay = new TimeTable(
                       match.Groups[1].Value,
                       match.Groups[2].Value,
                       match.Groups[3].Value,
                       match.Groups[4].Value);
                    runningDays.Add(runningDay);
                }
            }

            return runningDays;
        }
    }
}
