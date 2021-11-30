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
        private readonly IScheduleFactory _scheduleFactory;

        public ScheduleParser(IScheduleFactory _scheduleFactory)
        {
            this._scheduleFactory = _scheduleFactory;
        }
        public List<Schedule> ParseSchedule(string[] scheduleInput)
        {
            var schedules = new List<Schedule>();


            try
            {
                Regex rgx = new Regex(RegexPatternConstants.ScheduleParserRegexExpression);

                foreach (var schedule in scheduleInput)
                {
                    foreach (Match match in rgx.Matches(schedule))
                    {

                        var timetable = (Schedule)this._scheduleFactory
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

                throw new ParserException($"Could not parse {Constants.FileLocation.ScheduleFileLocationString}");
            }
        }
    }
}
