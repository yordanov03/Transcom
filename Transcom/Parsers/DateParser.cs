using System;
using System.Text.RegularExpressions;

namespace Transcom.Parsers
{
    public class DateParser
    {
        public DateTime ParseDate(string inputDate)
        {
            var dateRegexPattern = @"(\d{2})(\d{2})(\d{4})";
            var match = Regex.Match(inputDate, dateRegexPattern);

            var day = int.Parse(match.Groups[1].Value);
            var month = int.Parse(match.Groups[2].Value);
            var year = int.Parse(match.Groups[3].Value);

            DateTime parsedDate = new DateTime(year, month, day);

            return parsedDate;
        }
    }
}
