using PSITranscom.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Transcom.Exceptions;
using Transcom.Factories.TimetableFactory;
using static Transcom.Constants;

namespace Transcom.Parsers
{
    public class ScheduleParser : IScheduleParser
    {

        public List<Schedule> ParseSchedule(string[] runningDaysInput)
        {
            var schedules = new List<Schedule>();
            var scheduleFactory = new ScheduleFactory();

            try
            {
                Regex rgx = new Regex(RegexPatternConstants.ScheduleParserRegexExpression);

                foreach (var day in runningDaysInput)
                {
                    foreach (Match match in rgx.Matches(day))
                    {

                        var timetable = (Schedule)scheduleFactory
                            .WithValidFrom(match.Groups[1].Value)
                            .WithRunningCode(match.Groups[2].Value)
                            .WithValidTo(match.Groups[3].Value)
                            .WithTrainNumber(match.Groups[4].Value)
                            .Build();


                        schedules.Add(timetable);
                    }
                }

                return schedules;
            }
            catch
            {

                throw new ParserException($"Could not parse {FileLocation.ScheduleFileLocationString}");
            }
        }
    }
}
