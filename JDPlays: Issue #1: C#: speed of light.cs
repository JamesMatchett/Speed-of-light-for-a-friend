//for https://github.com/JamesMatchett/James-Helps-Friends-Code/issues/1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance the light has to travel in meters");
            decimal meters = Convert.ToDecimal(Console.ReadLine());

            //speed of light in m/s
            const decimal SpeedOfLight = 299792458;

            //using v = d/t -> t =d/v
            decimal time = meters / SpeedOfLight;

            Console.WriteLine("The time it takes light to travel {0} meters is {1} seconds", meters, time);
            Console.ReadKey();
        }
    }
}
