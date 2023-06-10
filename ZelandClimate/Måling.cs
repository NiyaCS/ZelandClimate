using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelandClimate
{
    internal class Måling
    {
        //properties
        public int id;
        public DateTime dateTime;
        public double temp;
        public int co2;
        public int antalPersoner;

        //constructors
        public Måling(int id, DateTime dateTime, double temp, int co2, int antalPersoner)
        {
            ID = id;
            DateTime = dateTime;
            Temp = temp;
            Co2 = co2;
            AntalPersoner = antalPersoner;

        }
        // get set
        public int ID { get; set; }
        public DateTime DateTime { get; set; }
        public double Temp { get; set; }   
        public int Co2 { get; set; }
        public int AntalPersoner { get; set; }

        // to string method
        public override string ToString()
        {
            return $"Måling's info: {ID}, {DateTime}, {Temp}, {Co2}, {AntalPersoner}";
        }
    }

}