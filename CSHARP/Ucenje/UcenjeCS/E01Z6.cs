

namespace UcenjeCS
{
    internal class E01Z6
    {
        public static void Izvedi() 
        {
            //Program od korisnika učitava ime grada i broj stanovnika.
            //Ispisuje rečenicu U xxxxxxxxxx živi xxxx stanovnika.

            Console.WriteLine("Upiši ime grada  ");
            string grad= Console.ReadLine();

            Console.WriteLine("Upiši broj stanovnika  ");
            int bs = int.Parse(Console.ReadLine());

            Console.WriteLine("U {0} živi {1} broj stanovnika.",grad,bs);
        }
    }
}
