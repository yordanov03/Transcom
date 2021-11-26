using PSITranscom.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Transcom.Factories;
using static Transcom.Constants;

namespace Transcom.Parsers
{
    public static class RunningDayParser
    {
        public static List<DailyRoute> Parse(string[] runningCalendarInput, string[] runningCodes)
        {
            var dailyRoutes = new List<DailyRoute>();
            var dailyRouteFactory = new DailyRouteFactory();

            Regex rgx = new Regex(RegexPatternConstants.DayParserRegexExpression);

            foreach (var calendar in runningCalendarInput)
            {
                foreach (Match match in rgx.Matches(calendar))
                {
                    foreach (var code in runningCodes)
                    {
                        var dailyRunningCode = match.Groups[1].Value;

                        if (code == dailyRunningCode)
                        {

                            //var parsedRunningCalendar = new DailyRoute(
                            //match.Groups[1].Value,
                            //match.Groups[2].Value);

                            var parsedDailyRoute = (DailyRoute) dailyRouteFactory
                                .WithRunningDailyCode(match.Groups[1].Value)
                                .WithRunningDate(match.Groups[2].Value)
                                .Build();

                            dailyRoutes.Add(parsedDailyRoute);
                        }
                    }

                }
            }

            return dailyRoutes;
        }
    }
}
