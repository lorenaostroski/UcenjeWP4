using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z1
    {

        public static void Izvedi() 
        {
            //zadatak:
            //Program od korisnika traži unos broj godina koje ima korisnik
            //Program ispisuje dali je korisnik punoljetne osoba ili ne

            Console.WriteLine("Unesite broj godina koje imate: ");
            var godine= int.Parse(Console.ReadLine());


            if (godine >= 18)
            {
                Console.WriteLine("Punoljetni ste.");
            
            }
            else 
            {
                Console.WriteLine("Niste punoljestni.");
            }

            //ili još jednostavnije

            Console.WriteLine("Unesi broj godina: ");
            var g= int.Parse(Console.ReadLine());
            Console.WriteLine(g>=18? "Punoljetna":"Maloljetna");





        }





    }
}
