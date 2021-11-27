namespace Transcom.Exceptions
{
    public class DailyRouteParserException : BaseParserException
    {
        public DailyRouteParserException(string error) => this.Error = error;

    }
}
