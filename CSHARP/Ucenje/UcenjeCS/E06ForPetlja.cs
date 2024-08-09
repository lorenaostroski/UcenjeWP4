

namespace UcenjeCS
{
    internal class E06ForPetlja
    {
        public static void Izvedi() 
        {
            Console.WriteLine("*********************");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Osijek");

            }

            Console.WriteLine("*********************");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("********************");
            //Zbrojiti prvih 100 brojeva
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);

            Console.WriteLine("*********************");

            //ispiši sve parne brojeve od 3 do 29
            //loše rješenje
            for (int i = 4; i < 29; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********************");

            int brojOd = 3;// ovo se može učitati od korisnika
            int brojDo = 29;//ovo se može učitati od korisnika
            // u nastavku u kodu nema konstanti
            for (int i = brojOd; i < brojDo; i++)
            { 
                if(i%2 == 0) 
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("*********************");

                int[] niz = { 2, 3, 2, 3, 32, 4, 5, 6, 7 };

                for (int j = 0; j < niz.Length; j++)
                {
                    Console.WriteLine(niz[j]);
                }

                Console.WriteLine("*********************");
                // ispiši sve brojeve od 20 do 10

                for (int a = 20; a >= 10; a--) 
                {
                    Console.WriteLine(a);
                }

                //ispiši sve prim brojeve od 2 do 14
                int ukupno = 0;
                bool prim;
                for (int a = 2; a < 1400; a++)
                {   
                    prim = true;
                    for (int j = 2; j < a; j++)

                    {
                        // Console.WriteLine("{0}&{1}={2}", a, j, a & j);
                        if (a % j == 0)
                        {
                            prim = false;//2000000 da li je prim broj
                            //prekini unutarnju petlju jer sve ostale provjere nisu više bitne
                            break;
                        }
                        if (!prim) 
                        { 
                            ukupno ++;
                            //Console.WriteLine("Nepotrebno izvođenje"+ ++ukupno);
                        }
                    }
                    if (prim)
                    { 
                        Console.WriteLine(a); 
                    }
                        
                    
                }
                Console.WriteLine("nepotreno izvodio:" + ukupno);

                Console.WriteLine("************************");
                //preskakanje petlje
                for (int a = 0; a < 10; a++)
                {
                    if (a == 3)
                    {
                        continue;
                    }
                    if (a == 5)
                    {
                        break;
                    }
                    Console.WriteLine(a);

                }
                for (int a = 0; a < 10; a++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.WriteLine(a * j);
                        //želim prekinuti vanjsku petlju: varijaba a
                        goto labela;
                    }

                }
                labela:
                Console.WriteLine("********************");

                //beskonačna petlja
                //unesi broj između 1 i 10
                /*Console.WriteLine(int.MaxValue);
                int max=int.MaxValue;
                Console.WriteLine(max+1);

                int broj;
                for (; ; ) 
                {
                    Console.WriteLine("Unesi broj od 1 do 10: ");
                    broj=int.Parse(Console.ReadLine());
                    if(broj<1  || broj > 10)
                    {
                        Console.WriteLine("Nisam unio broj u rasponu!");
                    }
                    break;
                }
                Console.WriteLine(broj);
                */

                Console.WriteLine("************************");

                niz = PodaciInt.niz;

                Console.WriteLine(niz.Length);
                /*
                for (int a = 0; a < niz.Length; a++) 
                {
                    Console.WriteLine(niz[a]);
                }
                */

                // Postoji li dva ista broja? Ako postoji koji je to broj ?
                /*
                for (int a = 0; a < niz.Length; a++)
                {
                    if (i % 10000 == 0)
                    {
                        Console.WriteLine("*");
                    }
                    for (int j = a + 1; j < niz.Length; j++)
                    {
                        if (niz[a] == niz[j])
                        {
                            Console.WriteLine(niz[i]);
                            goto kraj;
                        }

                    }

                }
                kraj:
                Console.WriteLine("******************");*/


                string[] imena = PodaciString.Niz;

                Console.WriteLine(imena.Length);

                //string je isto niz,niz znakova

                string grad = "Osijek";

                Console.WriteLine(grad[0]);
                Console.WriteLine(grad[grad.Length-1]);
























            }















        }
    }
}
