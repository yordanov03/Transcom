using PSITranscom.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static Transcom.Constants;

namespace Transcom.Parsers
{
    public class RunningCalendarParser
    {
        public static List<RunningDay> Parse(string[] runningCalendarInput, int[] runningCodes)
        {
            var runningCalendar = new List<RunningDay>();
            var dateParser = new DateParser();

            Regex rgx = new Regex(RegexPatternConstants.CalendarParserRegexExpression);

            foreach (var calendar in runningCalendarInput)
            {
                foreach (Match match in rgx.Matches(calendar))
                {
                    foreach (var code in runningCodes)
                    {
                        var dailyRunningCode = int.Parse(match.Groups[1].Value);

                        if (code == dailyRunningCode)
                        {

                            var parsedRunningCalendar = new RunningDay(
                            int.Parse(match.Groups[1].Value),
                            dateParser.ParseDate(match.Groups[2].Value));

                            runningCalendar.Add(parsedRunningCalendar);
                        }
                    }

                }
            }

            return runningCalendar;
        }
    }
}
