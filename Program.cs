using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar catetos z, y:");

            double z = double.Parse(Console.ReadLine()); // z=3
            double y = double.Parse(Console.ReadLine()); // y=2

            double t = Math.Sqrt((z * z) + (y * y));
            //double a = Math.Acos(((z*z)+(t*t)-(y*y))/(2*z*t)); radianes 
            //double b = Math.Acos(((z*z)+(y*y)-(t*t))/(2*z*y)); radianes 
            //double c = Math.Acos(((t*t)+(y*y)-(z*z))/(2*y*t)); radianes 

            //Datos a hallar 
            // ley de coseno
            double a = Math.Acos(((z * z) + (t * t) - (y * y)) / (2 * z * t)) * (180 / Math.PI);
            double b = Math.Acos(((z * z) + (y * y) - (t * t)) / (2 * z * y)) * (180 / Math.PI);
            double c = Math.Acos(((t * t) + (y * y) - (z * z)) / (2 * y * t)) * (180 / Math.PI);

            Console.WriteLine("t:" + t);
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
            Console.WriteLine("c:" + c);
        }
    }
}
