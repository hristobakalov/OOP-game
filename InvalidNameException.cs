namespace OOP_Teamwork___Game
{
    using System;
    public class InvalidNameException : ApplicationException
    {
        public InvalidNameException(string message)
            : base(message)
        {
        }

        public InvalidNameException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
