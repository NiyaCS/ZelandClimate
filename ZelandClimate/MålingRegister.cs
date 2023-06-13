using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelandClimate
{
    public class MålingRegister
    {
        public List<Måling> Målinger { get; set; }

        public MålingRegister()
        {
            Målinger = new List<Måling>();
        }
        public void TilføjMåling(Måling måling)
        {
            //tilføj kode der indsætter en måling i målinger


           // Målinger.Add(new Måling(1, 2));
           // Målinger.Add(new Måling(3, 4));

            //Eller:
            Måling.Add(Målinger);
            Måling.Add();


        }
        public void SletMåling(Måling måling)
        {
            //tilføj kode der sletter en måling i målinger


        }

        public PrintAlleMålinger()//skal nok ikke have input, da ´vi i samme klasse)
        {
            //tilføj kode der printer alle målinger i registeret
        }

        public HentMåling()
        {
            //tilføj kode der henter en enkelt måling i registeret
        }
    }

}
