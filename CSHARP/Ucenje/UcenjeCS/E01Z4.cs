

namespace UcenjeCS
{
    internal class E01Z4
    {
        public static void Izvedi()
        {
            //Korisnik unosi brojčani iznos ocjene.Program ispisuje
            //tekstualno ocjenu

            Console.WriteLine("Unesi prvu rečenicu: ");
            string recenica1= Console.ReadLine();

            Console.WriteLine("Unesi drugu rečenicu: ");
            string recenica2=Console.ReadLine();

            Console.WriteLine(recenica1 + " " + recenica2);

            Console.WriteLine("{0} {1}", recenica1,recenica2 );
        }
    }
}
