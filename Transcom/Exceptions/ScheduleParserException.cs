namespace Transcom.Exceptions
{
    public class ScheduleParserException : BaseParserException
    {
        public ScheduleParserException(string error) => this.Error = error;

    }
}
