﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17Subota
{
    internal class Raspored
    {
        private static object return1;

        public Raspored() 
        {
            // u ljetim mjesecim asvakih mjesec dana a u zimskim svaka dva tjeda

            DateTime datumOd = DateTime.Parse("2024-07-08");
            DateTime datumDo = datumOd;
            DateTime tjedan = datumOd;
            int broj = 0;

            while (datumOd.Year < 2028)
            {
                if (tjedan.Month >= 4 && tjedan.Month <= 10)
                {
                    datumDo = datumOd.AddDays(27);
                }
                else
                {
                    datumDo = datumOd.AddDays(6);
                }
                tjedan = datumOd.AddDays(6);

                Console.WriteLine("{0} - {1}, Stan {2}",
                    datumOd.ToString("dd.MM.yyyy."),
                    tjedan.ToString("dd.MM.yyyy."),++broj%3+1 );
                datumOd = datumDo.AddDays(1);
            }    
        
            
        }
    }
}
