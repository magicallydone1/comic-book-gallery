using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PriceListApplication3
{
    class PriceListApplication3
    {
        static void Main()
        {
            int item;
            try
            {
                Write("Enter an item number >> ");
                item = Convert.ToInt32(ReadLine());
                PriceList.DisplayPrice(item);
            }
            catch (Exception e)
            {
                WriteLine("Error!");
                WriteLine(e.Message);

                //WriteLine(e.StackTrace);
            }
         }
      }
         class PriceList
    {
        private static double[] price = { 15.99, 27.88, 34.56, 45.89 };

        public static void DisplayPrice(int item)
        {
            double tax;
            double total;
            double pr;
            pr = price[item];
            tax = pr * Tax.DetermineTaxRate(pr);
            total = pr + tax;
            WriteLine("The total price is" + total.ToString("C"));           
        }
    }
   class tax
    {
        private static double[] taxrate = { 0.06, 0.07 };
        private static double CUTTOFF = 20.00;
        public static double DetermineTaxRate(double price)
        {
          int subscript;
          double rate;
          if (price <= CUTTOFF)
                subscript = 0;
            else
                subscript = 2;  //Don't Do It! This mistake is intentional.
            rate = taxRate[subscript];
            return rate;
        }
    }
}
