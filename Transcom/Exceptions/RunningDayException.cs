namespace Transcom.Exceptions
{
    public class RunningDayException : BaseModelException
    {
        public RunningDayException(string error) => this.Error = error;

    }
}
