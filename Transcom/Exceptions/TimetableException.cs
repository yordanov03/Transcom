namespace Transcom.Exceptions
{
    public class TimetableException : BaseModelException
    {
        public TimetableException(string error) => this.Error = error;

    }
}
