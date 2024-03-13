using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_OverloadExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caculator caculator = new Caculator();
            int res1 = caculator.Add(1, 2);
            int res2 = caculator.Add(1, 2, 3);
            double res3 = caculator.Add(4.0, 5.0);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
        }
    }

    class Caculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        // 重载方法
        // 方法的签名不包含返回值!
        public double Add(double a, double b)
        {
            return a + b;
        }

        // 再次重载
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
