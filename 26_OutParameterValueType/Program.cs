using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_OutParameterValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program.BuildInParse();
            Program.MyDoubleParser();
        }

        static void BuildInParse()
        {
            Console.WriteLine("Please input first number:");
            string arg1 = Console.ReadLine();
            double x = 0;
            bool b1 = double.TryParse(arg1, out x);
            if (b1 == false)
            {
                Console.WriteLine("Input error!");
                return;
            }

            Console.WriteLine("please input second number:");
            string arg2 = Console.ReadLine();
            double y = 0;
            bool b2 = double.TryParse(arg2, out y);
            if (b2 == false)
            {
                Console.WriteLine("Input error!");
                return;
            }

            double result = x + y;
            Console.WriteLine($"Result: {result}.");
        }

        static void MyDoubleParser()
        {
            double x = 100;
            //bool b = DoubleParser.TryParse("ABCV", out x);
            bool b = double.TryParse("ABCV", out x);
            if (b == true)
            {
                Console.WriteLine(x + 1);
            }
            else
            {
                Console.WriteLine(x);  // 内置的double.TryParse()方法也是将原值赋为0
            }
        }
    }

    class DoubleParser
    {
        public static bool TryParse(string input, out double result)
        {
            try
            {
                result = double.Parse(input);
                return true;
            }
            catch
            {
                result = 0;  // 有问题，将输出参数的值赋为0
                return false;
            }
        }
    }
}
