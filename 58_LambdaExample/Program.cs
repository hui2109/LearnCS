using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 最初的lambda表达式
            Func<int, int, int> func1 = new Func<int, int, int>((int a, int b) => { return a + b; });

            // 第一次改进
            Func<int, int, int> func2 = new Func<int, int, int>((a, b) => { return a + b; });

            // 第二次改进
            Func<int, int, int> func3 = new Func<int, int, int>((a, b) => a + b);

            // 第三次改进
            Func<int, int, int> func4 = (a, b) => a + b;

            // 调用具有委托类型参数的函数
            DoSomeCalc<int>((a, b) => a + b, 12, 45);  // 泛型委托的类型参数推断
        }

        static void DoSomeCalc<T>(Func<T, T, T> func, T x, T y)
        {
            T res = func(x, y);
            Console.WriteLine(res);
        }
    }
}
