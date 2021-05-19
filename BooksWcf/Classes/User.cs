using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BooksWcf
{
    [DataContract]
   
    public class User
    {
        
       
            [DataMember]
            private string username;
            public string Username
            {
                get { return username; }
                set { username = value; }
            }

            [DataMember]
            private string guid;
            public string GUID
            {
                get { return guid; }
                set { guid = value; }
            }

            public User(string username, string guid)
            {
                this.Username = username;
                this.GUID = guid;
            }
        
    }
}