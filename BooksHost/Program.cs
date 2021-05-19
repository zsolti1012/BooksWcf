using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BooksHost
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = "BooksHost";
            try
            {
                using (ServiceHost host =new ServiceHost(typeof(BooksWcf.BooksService)))
                {
                    
                    host.Open();
                    Console.WriteLine("A szerver elindult!");
                    Console.WriteLine("<<Nyomj Entert a bezáráshoz!>>");
                    
                    Console.ReadLine();
                }
                
            }
            catch  (Exception e)
            {
                Console.WriteLine("Hiba! "+e.Message);
                Console.ReadLine();
            }
        }
    }
}
