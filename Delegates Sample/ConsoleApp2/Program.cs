using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Mukuch";

            Person p2 = new Person();
            p2.Name = "Mukuch's axper 1";
            
            Person p3 = new Person()
            {
                Name = "Mukuch's quyr 1"
            };

            Person p4 = new Person()
            {
                Name = "Gago"
            };

            p1.BlessYouWishes += p2.SayBlessYou;
            p1.BlessYouWishes += p3.SayBlessYou;

            p4.BlessYouWishes += p2.SayBlessYou;
            p4.BlessYouWishes += p3.SayBlessYou;

            p1.Prshtal();

            p4.Prshtal();
            Console.Read();

        }
    }
}
