﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelandClimate
{
    public class Måling
    {
        //properties
        static private int nextId;
        // public DateTime dateTime;
        // public double temp;
        // public int co2;
        // public int antalPersoner;
        // public int lokaleId;


        // get set
        public int ID { get; set; }
        public DateTime DateTime { get; set; }
        public double Temp { get; set; }   
        public int Co2 { get; set; }
        public int AntalPersoner { get; set; }
        public Lokale Lokale { get; set; }

        //constructors
        public Måling(DateTime dateTime, double temp, int co2, int antalPersoner, Lokale lokale)
        {
            ID = Interlocked.Increment(ref nextId);
            DateTime = dateTime;
            Temp = temp;
            Co2 = co2;
            AntalPersoner = antalPersoner;
            Lokale = lokale;
        }

        // to string method
        public override string ToString()
        {
            return $"Måling's info: {ID}, {DateTime}, {Temp}, {Co2}, {AntalPersoner}, {Lokale}";
        }
    }

}