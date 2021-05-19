using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksWcf
{
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException()
        {
        }
        public BookNotFoundException(string message)
        : base(message)
        {
        }
        public BookNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}