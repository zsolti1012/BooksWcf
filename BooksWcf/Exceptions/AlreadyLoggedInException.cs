using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksWcf
{
    public class AlreadyLoggedInException : Exception
    {
        public AlreadyLoggedInException()
        {
        }
        public AlreadyLoggedInException(string message)
        : base(message)
        {
        }
        public AlreadyLoggedInException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}