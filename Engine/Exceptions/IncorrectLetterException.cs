using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Exceptions
{
    public class IncorrectLetterException : Exception
    {
        public IncorrectLetterException(string message) : base(message)
        {

        }
    }
}
