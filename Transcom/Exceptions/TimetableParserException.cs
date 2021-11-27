namespace Transcom.Exceptions
{
    public class TimetableParserException : BaseParserException
    {
        public TimetableParserException(string error) => this.Error = error;
    }
}
