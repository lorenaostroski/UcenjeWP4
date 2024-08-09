

namespace UcenjeCS
{
    internal class E01Z5
    {
        public static void Izvedi() 
        {
            //Program od korisnika učitava decimalan broj te ispisuje drugi korijen učitanog broja.

            decimal x;
            Console.WriteLine("Unesi decimalni broj: ");
            x=decimal.Parse(Console.ReadLine());
            double y=Math.Sqrt(decimal.ToDouble(x));
            Console.WriteLine(y);

            //ILI

            Console.WriteLine("Unesi decimalni broj: ");
            Console.WriteLine(Math.Sqrt(double.Parse(Console.ReadLine())));
        }
    }
}
