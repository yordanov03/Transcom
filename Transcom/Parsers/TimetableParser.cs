using PSITranscom.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Transcom.Factories.TimetableFactory;
using static Transcom.Constants;
using PSITranscom.Models;

namespace Transcom.Parsers
{
    public static class TimetableParser
    {

        public static List<TimeTable> Parse(string[] runningDaysInput)
        {
            var timetables = new List<TimeTable>();
            var timetableFactory = new TimetableFactory();

            Regex rgx = new Regex(RegexPatternConstants.TimetableParserRegexExpression);

            foreach (var day in runningDaysInput)
            {
                foreach (Match match in rgx.Matches(day))
                {

                    var timetable = (TimeTable)timetableFactory
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
    }
}
