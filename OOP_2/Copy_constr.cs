/*
using System;
namespace copyConstructorExample
{

    class ASD
    {

        private string month;
        private int year;

       
        public ASD(ASD s)
        {
            month = s.month;
            year = s.year;
        }

        
        public ASD(string month, int year)
        {
            this.month = month;
            this.year = year;
        }

      
        public string Details
        {
            get
            {
                return "Ay: " + month.ToString() +
                        "\nYıl : " + year.ToString();
            }
        }

   
        public static void Main()
        {

          
            ASD g1 = new ASD("Agustos", 2023);

            ASD g2 = new ASD(g1);

            Console.WriteLine(g2.Details);
        }
    }
}
*/