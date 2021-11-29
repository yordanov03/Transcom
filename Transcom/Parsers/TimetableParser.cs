using PSITranscom.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Transcom.Exceptions;
using Transcom.Factories.ScheduleFactory;
using Transcom.Factories.TimetableFactory;
using static Transcom.Constants;

namespace Transcom.Parsers
{
    public class TimetableParser<T> : IParser<Timetable> where T : Timetable
    {
        public List<Timetable> ParseInput(string[] timeTableInput, string[] trainNumbers)
        {
            var parsedSchedules = new List<Timetable>();
            var scheduleFactory = new Schedule1Factory();

            try
            {
                Regex rgx = new Regex(RegexPatternConstants.TimetableParserRegularExpression);

                foreach (var timetable in timeTableInput)
                {
                    foreach (Match match in rgx.Matches(timetable))
                    {
                        var parsedTrainNumber = match.Groups[2].Value;

                        foreach (var trainNumber in trainNumbers)
                        {
                            if (trainNumber == parsedTrainNumber)
                            {
                                //var parsedtimetable = new Schedule(
                                //match.Groups[1].Value,
                                //parsedTrainNumber,
                                //match.Groups[3].Value,
                                //match.Groups[4].Value,
                                //match.Groups[5].Value);

                                var parsedSchedule = (Timetable)scheduleFactory
                                    .WithSequenceNumber(match.Groups[1].Value)
                                    .WithTrainNumber(parsedTrainNumber)
                                    .WithLoctionCode(match.Groups[3].Value)
                                    .WithArrivalTime(match.Groups[4].Value)
                                    .WithDepartureTime(match.Groups[5].Value)
                                    .Build();


                                parsedSchedules.Add(parsedSchedule);
                            }
                        }
                    }
                }

                return parsedSchedules;
            }
            catch
            {

                throw new ParserException($"Could not parse {FileLocation.TimetableFileLocationString}");
            }
        }
    }
}
