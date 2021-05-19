using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BooksWcf
{
    [DataContractAttribute]
    public class NoAvailableBookFault
    {
        private string report;

        public NoAvailableBookFault(string message)
        {
            this.report = message;
        }

        [DataMemberAttribute]
        public string Message
        {
            get { return this.report; }
            set { this.report = value; }
        }
    }
}