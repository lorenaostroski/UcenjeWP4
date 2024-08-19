using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.Nasljedivanje
{
    internal class Smjer
    {
        public string? Naziv { get; set; }
        public bool VidiSeUPodKlasi { get; private set; }


        // prepisivanje (override) metode ja kada u podklasi definiramo
        // metodu istog naziva u nadklasi
        public override string ToString()
        {
            Console.WriteLine(VidiSeUPodKlasi);
            return this.Naziv;
        }
    }
}
