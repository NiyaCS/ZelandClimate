namespace ZelandClimate
{
    internal class Program
    {
        private static object måling;

        static void Main(string[] args)
        {

            // (Afprøver klassen Måling i main metode opgave), opretter nyt måling project 
            Måling målinglokale1 = new Måling(1, DateTime.Now, 25.5, 100, 25);
            Måling målinglokale2 = new Måling(2, DateTime.Now, 23.4, 90, 30);

            // udskriver målingens properties.

            Console.WriteLine("Målinglokale1:");
            Console.WriteLine("ID: " + målinglokale1.ID);
            Console.WriteLine("DateTime: " + målinglokale1.DateTime);
            Console.WriteLine("Temp: " + målinglokale1.Temp);
            Console.WriteLine("CO2" + målinglokale1.Co2);
            Console.WriteLine("Antal personer: " + målinglokale1.AntalPersoner);


            
        }
    }
}