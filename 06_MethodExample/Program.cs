using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_MethodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caculator caculator = new Caculator();

            double r = 2.0;
            double h = 3.0;

            double circleArea = caculator.GetCircleArea(r);
            double cylinderVolume = caculator.GetCylinderVolume(r, h);
            double coneVolume = caculator.GetConeVolume(r, h);

            Console.WriteLine($"circleArea is {circleArea}");
            Console.WriteLine($"cylinderVolume is {cylinderVolume}");
            Console.WriteLine($"coneVolume is {coneVolume}");
        }

        class Caculator
        {
            public double GetCircleArea(double r)
            {
                return Math.PI * r * r;
            }

            public double GetCylinderVolume(double r, double h)
            {
                return GetCircleArea(r) * h;
            }

            public double GetConeVolume(double r, double h)
            {
                return GetCylinderVolume(r, h) / 3;
            }
        }
    }
}
