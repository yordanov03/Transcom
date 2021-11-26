namespace Transcom.Exceptions
{
    public class ScheduleException : BaseModelException
    {
        public ScheduleException(string error) => this.Error = error;
    }
}
