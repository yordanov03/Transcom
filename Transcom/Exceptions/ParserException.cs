using System;

namespace Transcom.Exceptions
{
    public class ParserException : Exception
    {
        //private string error;

        public ParserException(string message) : base(message)
        {
        }

        //public string Error
        //{
        //    get => this.error ?? base.Message;
        //    set => this.error = value;
        //}
    }
}
