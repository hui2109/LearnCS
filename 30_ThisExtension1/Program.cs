using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_ThisExtension1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 3.14159;
            double y = x.Round(4);  // 直接调用Round方法
            Console.WriteLine(y);
        }
    }

    // this扩展方法
    static class DoubleExtension  // 静态类 + Extension后缀（非必须）
    {
        public static double Round(this double input, int digits)  // 公共静态方法 + this关键字
        {
            double result = Math.Round(input, digits);
            return result;
        }
    }
}
