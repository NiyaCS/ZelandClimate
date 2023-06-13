using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelandClimate
{
<<<<<<< HEAD
    internal class MålingRegister
    {
    }
=======
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
           //Kan man gøre, hvis man har get setters + to string:
           måling.Add(new Måling() { Måling1 = "123", MålingId = 1234 });
            

        }
        public void SletMåling(Måling måling)
        {
            //tilføj kode der sletter en måling i målinger

            Måling.Remove(Målinger)
           

        }

        public PrintAlleMålinger()//skal nok ikke have input, da ´vi i samme klasse)
        {
            //tilføj kode der printer alle målinger i registeret
            //Bruger en for loop
            for(int i=0;i<months.Count;i++)
            {
            Console.WriteLine(måling[i]);
            }

        }

        public HentMåling()
        {
            //tilføj kode der henter en enkelt måling i registeret
            Måling.Find() 

        }
    }
}
