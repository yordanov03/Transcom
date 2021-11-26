namespace Transcom
{
    public static class Constants
    {
        public static class RegexPatternConstants
        {
            public const string TimetableParserRegexExpression = @"(\d{8})(\d{4})(\d{8})(\d{4})";
            public const string DayParserRegexExpression = @"(\d{4})(\d{8})";
            public const string ScheduleParserRegularExpression = @"(\d{5})(\d{4})(\d{5})(....)(....)*";
        }
    }
}
