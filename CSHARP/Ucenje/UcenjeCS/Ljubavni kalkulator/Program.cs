using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.Ljubavni_kalkulator
{
    internal class Program
    {
        

        public Program()
        {
            
             {
            
           
                string ime1 = "Voljen";
                string ime2 = "Marina";

                Console.WriteLine(ime1);
                Console.WriteLine(ime2);

                List<int> counts = new List<int>();

                string combinedNames = ime1 + ime2;

                // Broji pojavljivanja svakog slova
                foreach (char c in combinedNames)
                {
                    counts.Add(combinedNames.Split(c).Length - 1);
                }

                // Ispis broja pojavljivanja
                foreach (int count in counts)
                {
                    Console.Write(count + " ");
                }
                Console.WriteLine();

                // Zbroji brojeve 
                while (counts.Count > 2)
                {
                    List<int> newCounts = new List<int>();
                    int i = 0;
                    int j = counts.Count - 1;

                    while (i < j)
                    {
                        newCounts.Add(counts[i] + counts[j]);
                        i++;
                        j--;
                    }

                    //  dodaj srednji element, ako je neparan broj
                    if (i == j)
                    {
                        newCounts.Add(counts[i]);
                    }

                    counts = newCounts;

                    foreach (int count in counts)
                    {
                        Console.Write(count + " ");
                    }
                    Console.WriteLine();
                }

                // Ako imamo dva broja, onda su to postoci
                if (counts.Count == 2)
                {
                    int percentage = counts[0] * 10 + counts[1];
                    Console.WriteLine("Postotak ljubavi: " + percentage + "%");
                }
                else
                {
                    Console.WriteLine("Postotak ljubavi: " + counts[0] + "%");
                }
            
        }

         /* var ime1 = "Marta";
         var ime2 = "Manuel";

         string s = ime1[0].ToString();
         char c = ime1[0];

         Console.WriteLine(s);

         s = ime1.ToLower() + ime2.ToLower();

         Console.WriteLine(s);

         int[] brojevi = new int[s.Length];

         int u;
         for (int i = 0; i < s.Length; i++)
         {
             u = 0;
             for (int j = 0; j < s.Length; j++)
             {
                 if (s[i] == s[j])
                 {
                     u++;
                 }
             }
             brojevi[i] = u;
         }
        // Console.WriteLine(string.Join(",", brojevi));

         var niz= string.Join(",", brojevi);
         brojevi = new int[niz.Length];
         for (int i = 0; i<niz.Length; i++) 
         {
             brojevi[i] = int.Parse(niz[i].ToString());
         }



         Console.WriteLine(string.Join(",", brojevi));
         Console.WriteLine("{0} i {1} se vole {2}%", ime1,ime2,ljubav(brojevi));


     }
     private int ljubav(int[] brojevi) 
     {
         if (brojevi.Length < 4)
         {


             var broj = int.Parse(string.Join("", brojevi));
             if (broj <= 100)
             {
                 return broj;
             }

         }

         int[] novi= new int[brojevi.Length%2==0? brojevi.Length/2 : brojevi.Length/2+1];
         for (int i = 0; i < brojevi.Length / 2; i++)
         {
             novi[i] = brojevi[i] + brojevi[brojevi.Length - 1 - i];
         }

         if (brojevi.Length % 2 != 0) 
         {
             novi[novi.Length - 1] = brojevi[brojevi.Length/2];
         }

         novi=srediNiz(novi);

         Console.WriteLine(string.Join(",",novi));

         return ljubav(novi);

     }

     private int[] srediNiz(int[] brojevi) 
     {
         var niz = string.Join(",", brojevi);
         brojevi = new int[niz.Length];
         for (int i = 0; i < niz.Length; i++)
         {
             brojevi[i] = int.Parse(niz[i].ToString());
         }
         return brojevi;*/
    }






}
}
