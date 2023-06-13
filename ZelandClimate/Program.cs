namespace ZelandClimate
{
    internal class Program
    {
        private static object måling;

        static void Main(string[] args)
        {
            //generate lokale
            Lokale lokale1 = new Lokale("D 3. 06", 30);
            Lokale lokale2 = new Lokale("D 3. 07", 28);
            
            

            // (Afprøver klassen Måling i main metode opgave), opretter nyt måling project 
            // Måling måling1 = new Måling(DateTime.Now, 25.5, 100, 25);
            // Måling måling2 = new Måling(DateTime.Now, 23.4, 90, 30);

            // (Afprøver klassen Måling igen i main metode opgave), opretter nyt måling project 
            Måling målinglokale1 = new Måling(DateTime.Now, 25.5, 100, 25, lokale1);

            // generate målinger
            MålingRegister målingRegister = new MålingRegister();


            // udskriver målingens properties.
            Console.WriteLine("Målinger: " + målingRegister);

            Console.WriteLine("Målinglokale1:");
            Console.WriteLine("ID: " + målinglokale1.ID);
            Console.WriteLine("DateTime: " + målinglokale1.DateTime);
            Console.WriteLine("Temp: " + målinglokale1.Temp);
            Console.WriteLine("CO2" + målinglokale1.Co2);
            Console.WriteLine("Antal personer: " + målinglokale1.AntalPersoner);
            Console.WriteLine("Lokale målingen blev lavet: " + målinglokale1.Lokale.ID);



            
        }
    }
}