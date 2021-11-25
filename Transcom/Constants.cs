namespace Transcom
{
    public static class Constants
    {
        public static class RegexPatternConstants
        {
            public const string DayParserRegexExpression = @"(\d{8})(\d{4})(\d{8})(\d{4})";
            public const string CalendarParserRegexExpression = @"(\d{4})(\d{8})";
            public const string TimetableParserRegularExpression = @"(\d{5})(\d{4})(\d{5})(....)(....)*";
        }
    }
}
