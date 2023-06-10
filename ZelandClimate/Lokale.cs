using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelandClimate
{
    internal class Lokale
    {
        public int id;
        public string lokaleNummer;
        public int maxAntal;
        
        // constructors

        public Lokale(int id, string lokaleNummer, int maxAntal)
        {

            ID = id;
            LokaleNummer = lokaleNummer;
            MaxAntal = maxAntal;


        }

        public int ID { get; set; }
        public string LokaleNummer { get; set; }
        public int MaxAntal { get; set; }



        public override string ToString()
        {
            return $"Lokale's info: {ID}, {LokaleNummer}, {MaxAntal}";
        }
    }


}
