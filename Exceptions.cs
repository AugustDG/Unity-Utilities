using System;

namespace Utilities.Exceptions
{
    public class InvalidType : Exception
    {
        public InvalidType() {}
        
        public InvalidType(string type):base(String.Format("Invalid type, received {0}", type)) {}
    }
}