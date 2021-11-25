using PSITranscom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Transcom.Constants;

namespace Transcom.Parsers
{
    public class TimeTableParser
    {
        public static List<Timetable> Parse(string[] timeTableInput)
        {
            var parsedTimeTables = new List<Timetable>();

            Regex rgx = new Regex(RegexPatternConstants.TimetableParserRegularExpression);

            foreach (var timetable in timeTableInput)
            {
                foreach (Match match in rgx.Matches(timetable))
                {
                    var parsedtimetable = new Timetable(
                        int.Parse(match.Groups[1].Value),
                        int.Parse(match.Groups[2].Value),
                        match.Groups[3].Value,
                        match.Groups[4].Value,
                        match.Groups[5].Value);

                    parsedTimeTables.Add(parsedtimetable);
                }
            }

            return parsedTimeTables;
        }
    }
}
