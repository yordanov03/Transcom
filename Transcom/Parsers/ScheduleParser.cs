using PSITranscom.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Transcom.Factories.TimetableFactory;
using static Transcom.Constants;
using PSITranscom.Models;
using Transcom.Exceptions;

namespace Transcom.Parsers
{
    public static class ScheduleParser
    {

        public static List<Schedule> Parse(string[] runningDaysInput)
        {
            var timetables = new List<Schedule>();
            var timetableFactory = new ScheduleFactory();

            try
            {
                Regex rgx = new Regex(RegexPatternConstants.ScheduleParserRegexExpression);

                foreach (var day in runningDaysInput)
                {
                    foreach (Match match in rgx.Matches(day))
                    {

                        var timetable = (Schedule)timetableFactory
                            .WithValidFrom(match.Groups[1].Value)
                            .WithRunningCode(match.Groups[2].Value)
                            .WithValidTo(match.Groups[3].Value)
                            .WithTrainNumber(match.Groups[4].Value)
                            .Build();


                        timetables.Add(timetable);
                    }
                }

                return timetables;
            }
            catch
            {

                throw new ScheduleParserException($"Could not parse {FileLocation.ScheduleFileLocationString}");
            }
        }
    }
}
