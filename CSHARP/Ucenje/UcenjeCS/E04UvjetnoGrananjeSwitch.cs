﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04UvjetnoGrananjeSwitch
    {

        public static void Izvedi() 
        {
            //ako je i==0 ispiši DOBAR,1 LOŠ,2 ZAO

            int i= 0;

            switch (i)//radi s int,string i char tipovima podataka
            {
                case 0:
                    Console.WriteLine("DOBAR");
                    break;
                case 1:
                    Console.WriteLine("Loš");
                    break;
                case 2:
                    Console.WriteLine("ZAO");
                    break;
                default://TO JE ELSE U IF-U
                    Console.WriteLine("Nije definirano");
                    break;





            }
        
        
        }
    }
}
