﻿


using System.ComponentModel.Design;

namespace UcenjeCS

    /*Program učitava od korisnika ime grada. U ovisnosti o imenu grada ispisuje regiju prema
     Osijek>Slavonija
     Zadar>Dalmacija
     Čakovec> Međimurje
     Pula>Istra
     Za ostale unose program ispisuje: Ne znam koja je to regija
    */
{
    internal class E03Z4
    {
        internal static void Izvedi()
        {
            string grad = "Valpovo";
            if (grad == "Osijek")
            {
                Console.WriteLine("Slavonija");
            }
            else if (grad == "Zadar")
            {
                Console.WriteLine("Dalmacija");
            }
            else if (grad == "Čakovec")
            {
                Console.WriteLine("Međimurje");
            }
            else if (grad == "Pula")
            {
                Console.WriteLine("Istra");
            }
            else 
            {
                Console.WriteLine("Ne poznajem regiju. ");
            }


            switch (grad) 
            {
                case "Osijek":
                    Console.WriteLine("Slavonija");
                    break;

                case "Zadar":
                    Console.WriteLine("Dalmacija");
                    break;

                    //ostali slučajevi
                    default:
                    Console.WriteLine("Ne poznajem regiju");
                    break;



            }
        }   


    }
}
