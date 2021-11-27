namespace Transcom
{
    public static class Constants
    {
        public static class RegexPatternConstants
        {
            public const string ScheduleParserRegexExpression = @"(\d{8})(\d{4})(\d{8})(\d{4})";
            public const string DayParserRegexExpression = @"(\d{4})(\d{8})";
            public const string TimetableParserRegularExpression = @"(\d{5})(\d{4})(\d{5})(....)(....)*";
        }

        public static class FileLocation
        {
            public const string DailyRouteFileLocationString = @"C:\Users\sveto\source\repos\Transcom\Transcom\Source\A32_Sample SPOT Table TOMSCALENDAR.txt";
            public const string TimetableFileLocationString = @"C:\Users\sveto\source\repos\Transcom\Transcom\Source\A33_Sample SPOT Table TOMSTRAINDET.txt";
            public const string ScheduleFileLocationString = @"C:\Users\sveto\source\repos\Transcom\Transcom\Source\A34_Sample SPOT Table TOMSTRAINHEAD.txt";
        }
    }
}
