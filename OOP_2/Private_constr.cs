
using System;
namespace privateConstructorExample
{

    public class CNR
    {

        private CNR()
        {
        }

        public static int count_cnr;

        public static int cnr_Count()
        {
            return ++count_cnr;
        }

        public static void Main()
        {

            
            CNR.count_cnr = 156;

            CNR.cnr_Count();

            Console.WriteLine(CNR.count_cnr);

           
            CNR.cnr_Count();

            Console.WriteLine(CNR.count_cnr);
        }
    }
}
