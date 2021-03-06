using PSITranscom.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using PSITranscom.Exceptions;
using PSITranscom.Factories;
using static PSITranscom.Constants;

namespace PSITranscom.Parsers
{
    public class DailyRouteParser : IParser<DailyRoute>
    {
        private readonly IDailyRouteFactory _dailyRouteFactory;

        public DailyRouteParser(IDailyRouteFactory dailyRouteFactory)
        {
            this._dailyRouteFactory = dailyRouteFactory;
        }
        public List<DailyRoute> ParseInput(string[] runningCalendarInput, string[] runningCodes)
        {
            var dailyRoutes = new List<DailyRoute>();

            try
            {
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
                                var parsedDailyRoute = this._dailyRouteFactory
                                    .WithRunningDailyCode(dailyRunningCode)
                                    .WithRunningDate(match.Groups[2].Value)
                                    .Build();

                                dailyRoutes.Add(parsedDailyRoute);
                            }
                        }

                    }
                }
                return dailyRoutes;
            }
            catch
            {

                throw new ParserException($"{ErrorMessages.ParserErrorMessage}");
            }

        }
    }
}
