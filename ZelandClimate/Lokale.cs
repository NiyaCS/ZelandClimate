using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelandClimate
{
    public class Lokale
    {
        static private int nextId;
        public string lokaleNummer;
        public int maxAntal;
        

        public int ID { get; set; }
        public string LokaleNummer { get; set; }
        public int MaxAntal { get; set; }

        // constructors
        public Lokale(string lokaleNummer, int maxAntal)
        {

            ID = Interlocked.Increment(ref nextId);
            LokaleNummer = lokaleNummer;
            MaxAntal = maxAntal;

        }


        public override string ToString()
        {
            return $"Lokale's info: {ID}, {LokaleNummer}, {MaxAntal}";
        }
    }


}
