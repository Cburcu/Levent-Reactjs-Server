using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Exceptions
{
    public class GridCellException : Exception
    {
        public GridCellException(string message) : base(message)
        {

        }
    }
}
