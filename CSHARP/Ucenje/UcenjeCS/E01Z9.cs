


using System.Runtime.Intrinsics.X86;

namespace UcenjeCS
{
    internal class E01Z9
    {
        internal static void Izvedi()
        {
            //Program učitava od korisnika tri broja.
            //Program ispisuje razliku druga dva broja pribrojeno prvom broju

            int b1;
            Console.WriteLine("Unesi prvi broj ");
            b1=int.Parse(Console.ReadLine());

            int b2;
            Console.WriteLine("Unesi drugi broj ");
            b2=int.Parse(Console.ReadLine());

            int b3;
            Console.WriteLine("Unesi treći broj ");
            b3=int.Parse(Console.ReadLine());

            Console.WriteLine((b2 - b3) + b1);
        }
    }
}
