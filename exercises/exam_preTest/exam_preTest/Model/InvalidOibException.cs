using System;
using System.Runtime.Serialization;

namespace exam_preTest.Model
{
    [Serializable]
    internal class InvalidOibException : Exception
    {
        public InvalidOibException()
        {
        }

        public InvalidOibException(string message) : base(message)
        {
        }

        public InvalidOibException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidOibException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}