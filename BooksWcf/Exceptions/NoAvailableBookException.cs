using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksWcf
{
    public class NoAvailableBookException : Exception
    {
        public NoAvailableBookException()
        {
        }
        public NoAvailableBookException(string message)
        : base(message)
        {
        }
        public NoAvailableBookException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}