using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RestSharp;

namespace BooksWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BooksService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BooksService.svc or BooksService.svc.cs at the Solution Explorer and start debugging.
    public class BooksService : IBooksService
    {
        private string REST_URL = "http://localhost:8080/PHP/";
        //private string LOG = "abcd|1234";

        public bool Delete(string id, User client, string loginfo)
        {
            try
            {
                if (HasGuid(client))
                {
                    var restClient = new RestClient(REST_URL);
                    string ROUTE = "index.php";
                    var request = new RestRequest(ROUTE + "?log=" + loginfo+"&id="+id, Method.DELETE);
                    request.AddHeader("book_header", loginfo);
                    request.AddParameter("id", id);
                    IRestResponse<JSONResponse> response = restClient.Execute<JSONResponse>(request);

                    if (response.Content.Substring(1, response.Content.Length - 2) == "WRONG LOG INFO")
                    {
                        return false;
                    }

                    //if(!response.IsSuccessful) throw new BookNotFoundException();
                    else return true;
                }

                throw new LoginFailedException();
            }
            catch (BookNotFoundException)
            {
                throw new FaultException<BookNotFoundFault>(new BookNotFoundFault("Nincs ilyen könyv!!"), new FaultReason("Nincs ilyen könyv!"));
            }
            catch (NullReferenceException)
            {
                throw new FaultException<LoginFailedFault>(new LoginFailedFault("Autentikációs hiba!"), new FaultReason("Autentikációs hiba!"));
            }
            catch (LoginFailedException)
            {
                throw new FaultException<LoginFailedFault>(new LoginFailedFault("Autentikációs hiba!"), new FaultReason("Autentikációs hiba!"));
            }
            catch (Exception ex)
            {
                throw new FaultException(new FaultReason(ex.Message));
            }
        }

        public bool Insert(string name,string rating,string length,string ReleaseYear, User client, string loginfo)
        {
            try
            {
                if (!length.All(char.IsDigit)) throw new Exception("A hossz csak szám lehet!");
                if (!ReleaseYear.All(char.IsDigit)) throw new Exception("Az évszám csak szám lehet!");
                if (int.Parse(length) <= 0 || int.Parse(length) >= 5000) throw new Exception("A hossz 0 és 5000 között lehet!");
                if (int.Parse(ReleaseYear) <= 1800 || int.Parse(ReleaseYear) > DateTime.Now.Year) throw new Exception("A dátum 1800-nál későbbi és a jelengei évtől korábbi lehet!");

                if (HasGuid(client))
                {


                    var postBody = new
                    {
                        Name = name,
                        Rating = 0,
                        Length = int.Parse(length),
                        ReleaseYear = int.Parse(ReleaseYear)

                    };

                    var restClient = new RestClient(REST_URL);
                    string ROUTE = "index.php";
                    var request = new RestRequest(ROUTE + "?log=" + loginfo, Method.POST);
                    request.AddHeader("book_header", loginfo);
                    request.AddJsonBody(postBody);
                    IRestResponse<JSONResponse> response = restClient.Execute<JSONResponse>(request);

                    //return (response.Data.Status == "1") ? true : false;


                    if (response.Content.Substring(1, response.Content.Length - 2) == "WRONG LOG INFO")
                    {
                        return false;
                    }
                    else return true;
                }

                throw new LoginFailedException(); 
            }
            catch (NullReferenceException)
            {
                throw new FaultException<LoginFailedFault>(new LoginFailedFault("Autentikációs hiba!"), new FaultReason("Autentikációs hiba!"));
            }
            catch (LoginFailedException)
            {
                throw new FaultException<LoginFailedFault>(new LoginFailedFault("Autentikációs hiba!"), new FaultReason("Autentikációs hiba!"));
            }
            catch (Exception ex)
            {
                throw new FaultException(new FaultReason(ex.Message));
            }
        }

        public List<Book> ListAll(User client,string loginfo)
        {
            try
            {
                if (HasGuid(client))
                {
                    var restClient = new RestClient(REST_URL);
                    string ROUTE = "index.php";
                    var request = new RestRequest(ROUTE + "?log=" + loginfo, Method.GET);
                    IRestResponse<List<Book>> response = restClient.Execute<List<Book>>(request);

                    if (response.Data.Count > 0)
                    {
                        return response.Data;
                    }
                    else
                    {
                        throw new NoAvailableBookException();
                    }
                }

                else { throw new LoginFailedException(); }
            }
            catch (NullReferenceException)
            {
                throw new FaultException<LoginFailedFault>(new LoginFailedFault("Autentikációs hiba!"), new FaultReason("Autentikációs hiba!"));
            }
            catch (LoginFailedException)
            {
                throw new FaultException<LoginFailedFault>(new LoginFailedFault("Autentikációs hiba!"), new FaultReason("Autentikációs hiba!"));
            }
            catch (NoAvailableBookException)
            {
                throw new FaultException<NoAvailableBookFault>(new NoAvailableBookFault("Nincs megjeleníthető adat!"), new FaultReason("Nincs megjeleníthető adat!"));
            }
            catch (Exception ex)
            {
                throw new FaultException(new FaultReason(ex.Message));
            }
        }

        public User Login(string username, string password)
        {
            try
            {
                if ( (username == "Zsolti" && password == "wcf"))
                {
                    User user = new User(username, Guid.NewGuid().ToString());
                    lock (Host.loggedIn)
                    {
                        Host.loggedIn.Add(user);
                    }
                    return user;
                }

                throw new LoginFailedException();
            }
            catch (NullReferenceException)
            {
                throw new FaultException<LoginFailedFault>(new LoginFailedFault("Autentikációs hiba!"), new FaultReason("Autentikációs hiba!"));
            }
            catch (LoginFailedException)
            {
                throw new FaultException<LoginFailedFault>(new LoginFailedFault("Autentikációs hiba!"), new FaultReason("Autentikációs hiba!"));
            }
            catch (IncorrectPasswordException)
            {
                throw new FaultException<IncorrectPasswordFault>(new IncorrectPasswordFault("Helytelen jelszó!"), new FaultReason("Helytelen jelszó!"));
            }
            catch (Exception ex)
            {
                throw new FaultException(new FaultReason(ex.Message));
            }
        }

        public bool Logout(User client)
        {
            try
            {
                if (HasGuid(client))
                {
                    lock (Host.loggedIn)
                    {
                        var item = Host.loggedIn.Where(u => u.Username == client.Username && u.GUID == client.GUID).First();
                        Host.loggedIn.Remove(item);
                    }
                    return true;
                }

                return false;
            }
            catch (NullReferenceException)
            {
                throw new FaultException<LoginFailedFault>(new LoginFailedFault("Sikertelen bejelentkezés!"), new FaultReason("Sikertelen bejelentkezés!"));
            }
            catch (Exception ex)
            {
                throw new FaultException(new FaultReason(ex.Message));
            }
        }

        public bool Update(string id,string name,string rating,string length,string releaseYear, User client, string loginfo)
        {
           
            try
            {
                if (!length.All(char.IsDigit)||length==null) throw new Exception("A hossz csak szám lehet!");
                if (!releaseYear.All(char.IsDigit)||releaseYear==null) throw new Exception("Az évszám csak szám lehet!");
                if (int.Parse(length) <= 0 || int.Parse(length) >= 5000) throw new Exception("A hossz 0 és 5000 között lehet!");
                if (int.Parse(releaseYear) <= 1800 || int.Parse(releaseYear) > DateTime.Now.Year) throw new Exception("A dátum 1800-nál későbbi és a jelengei évtől korábbi lehet!");

                if (HasGuid(client))
                {
                    var postBody = SimpleJson.SerializeObject(new
                    {
                        Name = name,
                        Rating = rating,
                        Length = int.Parse(length),
                        ReleaseYear = int.Parse(releaseYear)
                    });

                    var restClient = new RestClient(REST_URL);
                    string ROUTE = "index.php";
                    var request = new RestRequest(ROUTE + "?log=" + loginfo + "&id=" + id, Method.PUT);
                    request.AddHeader("book_header", loginfo);
                    request.AddHeader("accept", "application/json");
                    request.AddHeader("Content-Type", "application/json");
                    request.AddParameter("id", id, ParameterType.QueryString);
                    request.AddJsonBody(postBody);

                    IRestResponse<JSONResponse> response = restClient.Execute<JSONResponse>(request);

                    if (response.Content.Substring(1, response.Content.Length - 2) == "WRONG LOG INFO")
                    {
                        return false;
                    }

                    //if(!response.IsSuccessful) throw new BookNotFoundException();
                    else return true;
                }

                throw new LoginFailedException();
            }
            catch (NullReferenceException)
            {
                throw new FaultException<LoginFailedFault>(new LoginFailedFault("Autentikációs hiba!"), new FaultReason("Autentikációs hiba!"));
            }
            catch (BookNotFoundException)
            {
                throw new FaultException<BookNotFoundFault>(new BookNotFoundFault("Nincs ilyen könyv!!"), new FaultReason("Nincs ilyen könyv!"));
            }
            catch (LoginFailedException)
            {
                throw new FaultException<LoginFailedFault>(new LoginFailedFault("Autentikációs hiba!"), new FaultReason("Autentikációs hiba!"));
            }
            catch (Exception ex)
            {
                throw new FaultException(new FaultReason(ex.Message));
            }
        }

        public bool HasGuid(User client)
        {
            try
            {
                foreach (var item in Host.loggedIn)
                {
                    if (item.GUID == client.GUID && item.Username == client.Username)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (NullReferenceException)
            {
                throw new FaultException<LoginFailedFault>(new LoginFailedFault("Autentikációs hiba!"), new FaultReason("Autentikációs hiba!"));
            }
            catch (Exception ex)
            {
                throw new FaultException(new FaultReason(ex.Message));
            }
        }

        public List<Book> ListById(string id, User client,string loginfo)
        {
            try
            {
                if (HasGuid(client))
                {
                    var restClient = new RestClient(REST_URL);
                    string ROUTE = "index.php?log="+loginfo+"&id="+id;
                    var request = new RestRequest(ROUTE , Method.GET);
                    request.AddParameter("id", id);
                    IRestResponse<List<Book>> response = restClient.Execute<List<Book>>(request);
                    if (response.Data.Count > 0)
                    {
                        return response.Data;
                    }

                    throw new BookNotFoundException();
                }

                throw new LoginFailedException();
            }
            catch (NullReferenceException)
            {
                throw new FaultException<LoginFailedFault>(new LoginFailedFault("Autentikációs hiba!"), new FaultReason("Autentikációs hiba!"));
            }
            catch (LoginFailedException)
            {
                throw new FaultException<LoginFailedFault>(new LoginFailedFault("Autentikációs hiba!"), new FaultReason("Autentikációs hiba!"));
            }
            catch (BookNotFoundException)
            {
                throw new FaultException<BookNotFoundFault>(new BookNotFoundFault("Nincs ilyen könyv!!"), new FaultReason("Nincs ilyen könyv!"));
            }
            catch (Exception ex)
            {
                throw new FaultException(new FaultReason(ex.Message));
            }
        }
    }
}
