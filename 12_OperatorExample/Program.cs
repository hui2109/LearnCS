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
            
            // 左移与右移操作符
            // 在数据位不溢出的情况下, 左移, 数*2; 右移, 数/2
            // 补位规则:
            // 左移: 补0
            // 右移: 是正数: 补0; 是负数: 补1
            int a = 120;
            int b = a << 1;  // 左移1位
            int c = a >> 2;  // 右移1位
            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
            Console.WriteLine(Convert.ToString(a, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(b, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(c, 2).PadLeft(32, '0'));
            
            // 按位与&   按位或|   按位异或^ 
            // 条件与&&    条件或||
            int d = 3;
            int e = 4;
            int f = 3;
            if (d > e && f++ > 3)
            { 
                Console.WriteLine("Hello");
            }
            Console.WriteLine(f);  // 3, 发生了短路!
        }
    }
}
