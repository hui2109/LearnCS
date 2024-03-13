using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_OperatorExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 取反操作符
            int x = 12345678;
            int y = ~x;
            int z = -x;
            Console.WriteLine(y);
            Console.WriteLine(z);
            // 结论: 取反的结果 = 取相反数的结果 - 1
            Console.WriteLine(Convert.ToString(x, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(y, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(z, 2).PadLeft(32, '0'));

            // 取非操作符
            bool m = true;
            bool n = !m;
            Console.WriteLine($"{m}, {n}");
        }
    }
}
