﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace BooksWcf
{
    [DataContractAttribute]
    public class LoginFailedFault
    {
        private string report;

        public LoginFailedFault(string message)
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