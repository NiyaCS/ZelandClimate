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


            Målinger.Add(måling);

        //eller:
            //måling.add(målinger);
            //måling.add();
        }


        //public void SletMåling(Måling måling)
        //{
        //    //tilføj kode der sletter en måling i målinger

        //    // Måling.Remove(Målinger)
        //}

        
        public void PrintAlleMålinger()//skal nok ikke have input, da vi er i samme klasse, skal ikke returnere noget, efter den er færdig med at køre)
        {
            //tilføj kode der printer alle målinger i registeret

            //Bruger en for loop
            for (int i = 0; i < Målinger.Count; i++)
            {
                Console.WriteLine(Målinger[i]);
            }
            
        }

        //public HentMåling()
        //{
        //    //tilføj kode der henter en enkelt måling i registeret
        //    // Måling.Find() 

        //}
    }
}
