using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_DelegateExample
{
    // 自定义委托，写在名称空间里，而不是类里，因为委托也是类！
    // 委托的定义很像方法，只是多了delegate关键字，少了方法体
    public delegate int MyCalc(int x, int y);

    internal class Program
    {
        static void Main(string[] args)
        {
            // Action 和 Func 是最常见的内置委托类型
            Action act = new Action(Calculator.Report);
            Func<int, int, int> func = new Func<int, int, int>(Calculator.Add);

            act.Invoke();
            act();  // Action可以直接调用
            int res = func.Invoke(100, 200);
            Console.WriteLine(res);

            // 自定义委托
            MyCalc myCalc = new MyCalc(Calculator.Add);
            res = myCalc.Invoke(300, 400);
            Console.WriteLine("-----------------------");
            Console.WriteLine(typeof(MyCalc).IsClass);  // Gets a value indicating whether the Type is a class or a delegate
            Console.WriteLine(res);
        }
    }

    class Calculator
    {
        public static void Report()
        {
            Console.WriteLine("I have some methods.");
        }

        public static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }
}
