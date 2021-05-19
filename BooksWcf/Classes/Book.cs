using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BooksWcf
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public int id { set; get; }
        [DataMember]
        public string name { set; get; }
        [DataMember]
        public  string rating { set; get; }
        [DataMember]
        public string length { set; get; }
        [DataMember]
        public string releaseYear { set; get; }

        public Book()
        {

        }

    }
}