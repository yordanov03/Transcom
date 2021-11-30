using PSITranscom.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Transcom.Exceptions;
using Transcom.Factories.ScheduleFactory;
using static Transcom.Constants;

namespace Transcom.Parsers
{
    public class TimetableParser : IParser<Timetable>
    {
        private readonly ITimetableFactory _timetableFactory;

        public TimetableParser(ITimetableFactory timetableFactory)
        {
            this._timetableFactory = timetableFactory;
        }
        public List<Timetable> ParseInput(string[] timeTableInput, string[] trainNumbers)
        {
            var parsedTimetables = new List<Timetable>();

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

                                var parsedSchedule = (Timetable)this._timetableFactory
                                    .WithSequenceNumber(match.Groups[1].Value)
                                    .WithTrainNumber(parsedTrainNumber)
                                    .WithLoctionCode(match.Groups[3].Value)
                                    .WithArrivalTime(match.Groups[4].Value)
                                    .WithDepartureTime(match.Groups[5].Value)
                                    .Build();


                                parsedTimetables.Add(parsedSchedule);
                            }
                        }
                    }
                }

                return parsedTimetables;
            }
            catch
            {

                throw new ParserException($"Could not parse {Constants.FileLocation.TimetableFileLocationString}");
            }
        }
    }
}
