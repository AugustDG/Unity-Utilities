using System;

namespace UnityUtilities.Exceptions
{
    public class InvalidTypeException : Exception
    {
        public InvalidTypeException() {}
        
        public InvalidTypeException(string received):base($"Invalid type, received: {received}") {}
    }
}