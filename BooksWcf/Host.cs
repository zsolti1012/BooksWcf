using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksWcf
{
    public class Host
    {
        public static Object toLock = new object();
        public static List<User> loggedIn = new List<User>();
    }
}