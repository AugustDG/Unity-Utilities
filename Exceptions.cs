using System;

namespace Utilities.Exceptions
{
    public class InvalidTypeException : Exception
    {
        public InvalidTypeException() {}
        
        public InvalidTypeException(string received):base($"Invalid type, received: {received}") {}
    }
}