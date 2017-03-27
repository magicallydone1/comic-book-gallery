using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MilesPerGallon
{
    class Program
    {
        static void Main()
        {
            int milesDriven;
            int gallonsOfGas;
            int mpg;
            try
            {
                Write("Enter miles driven");
                milesDriven = Convert.ToInt32(ReadLine());
                Write("Enter gallons of gas purchased");
                gallonsOfGas = Convert.ToInt32(ReadLine());
                mpg = milesDriven / gallonsOfGas;
            }

            catch(Exception e)
            {
                mpg = 0;
                WriteLine("You attempted to divide by zero!");
                WriteLine(e.Message);
            }
            WriteLine("You got {0} miles per gallon", mpg);
        }
    }
}
