using System;
using System.Runtime.Serialization;

namespace Gladiators
{
    [Serializable]
    internal class IncorrectYearNumberException : Exception
    {
        public IncorrectYearNumberException()
        {
        }

        public IncorrectYearNumberException(string message) : base(message)
        {
        }

        public IncorrectYearNumberException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IncorrectYearNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}