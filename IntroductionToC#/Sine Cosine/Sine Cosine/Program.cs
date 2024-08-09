using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sine_Cosine
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Set your angle");
            int angle =Convert.ToInt32(Console.ReadLine());

            float degree = (float) angle;
            float radians = degree * (float)Math.PI / 180; 

            float sine = (float) Math.Sin (radians);
            float cosine = (float) Math.Cos(radians);

            Console.WriteLine("The sine of " + degree + "º is " + sine);
            Console.WriteLine("The cosine of " + degree + "º is " + cosine);

        }
    }
}
