

namespace UcenjeCS
{
    internal class E05Z2
        //Definiraj dvodimenzionalni niz od 4 elementa koji su decimalni brojevi.
        //DZ:Korisnik upisuje vrijednosti.
        //Program ispisuje unesene brojeve jedno pokraj drugog odvojeno zarezom.
    {
        internal static void Izvedi()
        {
            int[,] niz = new int[,]
            {
                {2,2},
                {3,3}
            };

            Console.WriteLine("{0},{1},{2},{3}", niz[0, 0], niz[0, 1], niz[1, 0], niz[1,1]);





        }
    }
}
