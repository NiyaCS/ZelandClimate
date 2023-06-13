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
            //tilføj kode der indsætter en måling i


            Målinger.Add(måling);

        //eller:
            //måling.add(målinger);
            //måling.add();
        }

        public void OpretMåling(DateTime dateTime, double temp, int co2, int antalPersoner, Lokale lokale)
        {
            //tilføj kode der oprette en ny måling der bliver lagt ind i målingregistret

            Måling måling = new Måling(dateTime, temp, co2, antalPersoner, lokale);
            Målinger.Add(måling);
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

        public void HentMåling(int id)
        {
            //tilføj kode der henter en enkelt måling i registeret
            for (int i = 0; i < Målinger.Count; i++)
            {
                Console.WriteLine(Målinger[i].ID);

                if (id == Målinger[i].ID)
                {
                    Console.WriteLine("Vi har fundet den! " + Målinger[i]);
                   
                }
            }

            // Måling.Find() 

        }

        public Måling HentMålingFancy(int id)
        {
            //tilføj kode der henter en enkelt måling i registeret
            return Målinger.Find(m => m.ID == id);

            // Måling.Find() 

        }
    }
}
