namespace PSITranscom
{
    public static class Constants
    {
        public static class RegexPatternConstants
        {
            public const string ScheduleParserRegexExpression = @"(\d{8})(\d{4})(\d{8})(\d{4})";
            public const string DayParserRegexExpression = @"(\d{4})(\d{8})";
            public const string TimetableParserRegularExpression = @"(\d{5})(\d{4})(\d{5})(....)(....)*";
        }

        public static class FilePath
        {
            public const string OutputFileLocation = @"..\..\..\Output\";
        }

        public static class ErrorMessages
        {
            public const string ExecutorCompileMessage = "Could not compile program";
            public const string ExecutorProcessDataMessage = "Ops, something went wrong while processing the data";
            public const string ParserErrorMessage = "Could not parse file";
        }
    }
}
