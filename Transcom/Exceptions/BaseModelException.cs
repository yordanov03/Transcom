using System;

namespace Transcom.Exceptions
{
    public abstract class BaseModelException : Exception
    {
        private string error;

        public string Error
        {
            get => this.error ?? base.Message;
            set => this.error = value;
        }
    }
}
