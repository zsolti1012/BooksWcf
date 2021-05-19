using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BooksWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBooksService" in both code and config file together.
    [ServiceContract]
    public interface IBooksService
    {
        [OperationContract]
        [FaultContract(typeof(LoginFailedFault))]
        [FaultContract(typeof(NoAvailableBookFault))]
        List<Book> ListAll(User client,string loginfo);

        [OperationContract]
        [FaultContract(typeof(LoginFailedFault))]
        [FaultContract(typeof(BookNotFoundFault))]
        List<Book> ListById(string id, User client,string loginfo);

        [OperationContract]
        [FaultContract(typeof(LoginFailedFault))]
        bool Insert(string name,string rating,string lenght,string releaseYear, User client,string loginfo);

        [OperationContract]
        [FaultContract(typeof(LoginFailedFault))]
        bool Update(string id, string name, string rating, string lenght, string releaseYear, User client,string loginfo);

        [OperationContract]
        [FaultContract(typeof(LoginFailedFault))]
        bool Delete(string id, User client,string loginfo);

        [OperationContract]
        [FaultContract(typeof(LoginFailedFault))]
        User Login(string username, string password);

        [OperationContract]
        [FaultContract(typeof(LoginFailedFault))]
        bool Logout(User client);
    }
}
