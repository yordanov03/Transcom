using PSITranscom.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static Transcom.Constants;

namespace Transcom.Parsers
{
    public class RunningCalendarParser
    {
        public static List<RunningCalendar> Parse(string[] runningCalendarInput)
        {
            var runningCalendar = new List<RunningCalendar>();
            var dateParser = new DateParser();

            Regex rgx = new Regex(RegexPatternConstants.CalendarParserRegexExpression);

            foreach (var calendar in runningCalendarInput)
            {
                foreach (Match match in rgx.Matches(calendar))
                {
                    var parsedRunningCalendar = new RunningCalendar(
                       int.Parse(match.Groups[1].Value),
                       dateParser.ParseDate(match.Groups[2].Value));

                    runningCalendar.Add(parsedRunningCalendar);
                }
            }

            return runningCalendar;
        }
    }
}
