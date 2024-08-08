using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04Z1
    {

        public static void Izvedi() 
        {
            //ZADATAK:
            //Korisnik unosi brojčani iznos ocjene.Program ispisuje 
            //tekstualno ocjenu

            int ocjena;
            Console.WriteLine("Unesite ocjenu u brojčanom obliku: ");
            ocjena=int.Parse(Console.ReadLine());

            switch (ocjena)
            {
                case 0:
                    Console.WriteLine("DOBAR");
                    break;
                case 1:
                    Console.WriteLine("ODLIČAN");
                    break;
                default:
                    Console.WriteLine("NIJE DEFINIRANO");
                    break;


            }






           




        }
    }
}
